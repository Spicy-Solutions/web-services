using SweetManagerWebService.Inventory.Domain.Model.Commands;
using SweetManagerWebService.Inventory.Domain.Model.Exceptions.Supply;
using SweetManagerWebService.Inventory.Domain.Model.Exceptions.SupplyRequest;
using SweetManagerWebService.Inventory.Domain.Repositories;
using SweetManagerWebService.Inventory.Domain.Services;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Inventory.Application.Internal.CommandServices;

public class SupplyRequestCommandService(ISupplyRequestRepository supplyRequestRepository, ISupplyRepository supplyRepository, IUnitOfWork unitOfWork) : ISupplyRequestCommandService
{
    public async Task<bool> Handle(CreateSupplyRequestCommand command)
    {
        try
        {
            if (command.Count <= 0)
                throw new InvalidSupplyRequestCountException("The count must be greater than zero.");
            

            if (command.Amount <= 0)
                throw new InvalidSupplyRequestAmountException("The amount must be greater than zero.");


            var supply = await supplyRepository.FindByIdAsync(command.SupplyId);
            if (supply == null)
                throw new SupplyNotFoundException($"The supply with ID {command.SupplyId} was not found.");

 

            var suppliesRequest = new Domain.Model.Entities.SupplyRequest(command); 

            await supplyRequestRepository.AddAsync(suppliesRequest);
            
            await unitOfWork.CommitAsync();

            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}