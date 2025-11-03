using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using SweetManagerWebService.Commerce.Domain.Model.Queries;
using SweetManagerWebService.Commerce.Domain.Services;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;
using SweetManagerWebService.Commerce.Interfaces.REST.Transform;
using SweetManagerWebService.IAM.Infrastructure.Pipeline.Middleware.Attributes;

namespace SweetManagerWebService.Commerce.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Authorize]
public class PaymentOwnerController(
    IPaymentOwnerCommandService paymentOwnerCommandService,
    IPaymentOwnerQueryService paymentOwnerQueryService,
    IDashboardQueryService dashboardQueryService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreatePaymentOwner(CreatePaymentOwnerResource resource)
    {
        var createPaymentOwnerCommand = CreatePaymentOwnerCommandFromResourceAssembler.ToCommandFromResource(resource);
        var paymentOwner = await paymentOwnerCommandService.Handle(createPaymentOwnerCommand);
        if (paymentOwner is null) return BadRequest();
        var paymentOwnerResource = PaymentOwnerResourceFromEntityAssembler.ToResourceFromEntity(paymentOwner);
        return CreatedAtAction(nameof(GetPaymentOwnerById), new { paymentOwnerId = paymentOwnerResource.Id }, paymentOwnerResource);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllPaymentOwners()
    {
        var getAllPaymentOwnersQuery = new GetAllPaymentOwnersQuery();
        var paymentOwners = await paymentOwnerQueryService.Handle(getAllPaymentOwnersQuery);
        var paymentOwnerResources = paymentOwners.Select(PaymentOwnerResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(paymentOwnerResources);
    }
    
    [HttpGet("{paymentOwnerId:int}")]
    public async Task<IActionResult> GetPaymentOwnerById(int paymentOwnerId)
    {
        var getPaymentOwnerByIdQuery = new GetPaymentOwnerByIdQuery(paymentOwnerId);
        var paymentOwner = await paymentOwnerQueryService.Handle(getPaymentOwnerByIdQuery);
        if (paymentOwner == null) return NotFound();
        var paymentOwnerResource = PaymentOwnerResourceFromEntityAssembler.ToResourceFromEntity(paymentOwner);
        return Ok(paymentOwnerResource);
    }
    
    [HttpGet("by-owner/{ownerId:int}")]
    public async Task<IActionResult> GetPaymentOwnersByOwnerId(int ownerId)
    {
        var getPaymentOwnerByOwnerIdQuery = new GetAllPaymentOwnersByOwnerIdQuery(ownerId);
        var paymentOwners = await paymentOwnerQueryService.Handle(getPaymentOwnerByOwnerIdQuery);
        var paymentOwnerResources = paymentOwners.Select(PaymentOwnerResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(paymentOwnerResources);
    }
    
    [HttpPut("{paymentOwnerId:int}")]
    public async Task<IActionResult> UpdatePaymentOwner(int paymentOwnerId, UpdatePaymentOwnerResource resource)
    {
        if (paymentOwnerId != resource.Id)
        {
            return BadRequest("Payment owner ID mismatch.");
        }

        var updatePaymentOwnerCommand = UpdatePaymentOwnerCommandFromResourceAssembler.ToCommandFromResource(resource);
        var paymentOwner = await paymentOwnerCommandService.Handle(updatePaymentOwnerCommand);
        if (paymentOwner is null) return NotFound();
        var paymentOwnerResource = PaymentOwnerResourceFromEntityAssembler.ToResourceFromEntity(paymentOwner);
        return Ok(paymentOwnerResource);
    }
    
    [HttpGet("weekly-incomes/{hotelId:int}")]
    public async Task<IActionResult> GetWeeklyComparativeIncomesAndExpenses(int hotelId)
    {
        try
        {
            var comparativeIncomes = await dashboardQueryService.Handle(new GetWeeklyIncomesByHotelIdQuery(hotelId));

            var comparativeIncomesResources =
                comparativeIncomes.Select(ComparativeWeeklyIncomeResourceFromEntityAssembler.ToResourceFromEntity);
            
            return Ok(comparativeIncomesResources);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet("monthly-incomes/{hotelId:int}")]
    public async Task<IActionResult> GetMonthlyComparativeIncomesAndExpenses(int hotelId)
    {
        try
        {
            var comparativeIncomes = await dashboardQueryService.Handle(new GetMonthlyIncomesByHotelIdQuery(hotelId));

            var comparativeIncomesResources =
                comparativeIncomes.Select(ComparativeMonthlyIncomeResourceFromEntityAssembler.ToResourceFromEntity);
            
            return Ok(comparativeIncomesResources);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}