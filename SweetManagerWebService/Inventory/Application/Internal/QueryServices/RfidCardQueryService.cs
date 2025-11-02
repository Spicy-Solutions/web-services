using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Queries.RFID;
using SweetManagerWebService.Inventory.Domain.Repositories;
using SweetManagerWebService.Inventory.Domain.Services;

namespace SweetManagerWebService.Inventory.Application.Internal.QueryServices;

public class RfidCardQueryService(IRfidCardRepository rfidCardRepository) : IRfidCardQueryService
{
    public async Task<IEnumerable<RfidCard>> Handle(GetAllRfidCardsQuery query)
    {
        return await rfidCardRepository.ListAsync();
    }

    public async Task<RfidCard?> Handle(GetRfidCardByIdQuery query)
    {
        return await rfidCardRepository.FindByIdAsync(query.Id);
    }
    
    public async Task<IEnumerable<RfidCard>> Handle(GetAllRfidCardsByHotelIdQuery query)
    {
        return await rfidCardRepository.FindByHotelIdAsync(query.HotelId);
    }
}