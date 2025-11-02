using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Queries.RFID;

namespace SweetManagerWebService.Inventory.Domain.Services;

public interface IRfidCardQueryService
{
    Task<IEnumerable<RfidCard>> Handle(GetAllRfidCardsQuery query);
    Task<RfidCard?> Handle(GetRfidCardByIdQuery query);
    Task<IEnumerable<RfidCard>> Handle(GetAllRfidCardsByHotelIdQuery query);
}