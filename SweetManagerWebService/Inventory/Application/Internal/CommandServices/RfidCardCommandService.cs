using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Commands;
using SweetManagerWebService.Inventory.Domain.Repositories;
using SweetManagerWebService.Inventory.Domain.Services;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Inventory.Application.Internal.CommandServices;

public class RfidCardCommandService(IRfidCardRepository rfidCardRepository, IUnitOfWork unitOfWork) : IRfidCardCommandService
{
    public async Task<RfidCard?> Handle(CreateRfidCardCommand command)
    {
        var rfidCard = new RfidCard(command);
        try
        {
            await rfidCardRepository.AddAsync(rfidCard);
            await unitOfWork.CommitAsync();
            return rfidCard;
        } catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the RFID Card: {e.Message}");
            return null;
        }
    }
}