using System.Net.Mime;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;
using SweetManagerWebService.OrganizationalManagement.Domain.Services;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Authorize]
public class ProvidersController(
    IProviderCommandService providerCommandService,
    IProviderQueryService providerQueryService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AddNewProvider(CreateProviderResource resource)
    {
        try
        {
            var createProviderCommand = CreateProviderCommandFromResourceAssembler.ToCommandFromResource(resource);
            var provider = await providerCommandService.Handle(createProviderCommand);

            if (provider is null) return BadRequest();
            var providerResource = ProviderResourceFromEntityAssembler.ToResourceFromEntity(provider);
            return CreatedAtAction(nameof(GetProviderById), new { providerId = providerResource.Id }, providerResource);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpGet("{providerId:int}")]
    public async Task<IActionResult> GetProviderById(int providerId)
    {
        try
        {
            var getProviderByIdQuery = new GetProviderByIdQuery(providerId);
            var provider = await providerQueryService.Handle(getProviderByIdQuery);

            if (provider == null) return NotFound();
            var providerResource = ProviderResourceFromEntityAssembler.ToResourceFromEntity(provider);
            return Ok(providerResource);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }

    }

    [HttpGet("hotel/{hotelId}")]
    public async Task<IActionResult> GetAllProviders(int hotelId)
    {
        try
        {
            var getAllProvidersQuery = new GetAllProvidersQuery(hotelId);
            var providers = await providerQueryService.Handle(getAllProvidersQuery);
            var providerResources = providers.Select(ProviderResourceFromEntityAssembler.ToResourceFromEntity);
            return Ok(providerResources);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPut("{providerId:int}")]
    public async Task<IActionResult> UpdateProvider(int providerId, UpdateProviderResource resource)
    {
        try
        {
            var updateProviderCommand =
                UpdateProviderCommandFromResourceAssembler.ToCommandFromResource(providerId, resource);
            var provider = await providerCommandService.Handle(updateProviderCommand);

            if (provider is null) return BadRequest();
            var providerResource = ProviderResourceFromEntityAssembler.ToResourceFromEntity(provider);
            return Ok(providerResource);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpDelete("{providerId:int}")]
    public async Task<IActionResult> DeleteProviderForClient(int providerId)
    {
        try
        {
            var deleteProviderCommand = new DeleteProviderCommand(providerId);
            var provider = await providerCommandService.Handle(deleteProviderCommand);

            if (!provider) return BadRequest();
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}