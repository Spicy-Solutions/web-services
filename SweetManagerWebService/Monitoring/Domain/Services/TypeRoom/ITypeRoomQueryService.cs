using SweetManagerWebService.Monitoring.Domain.Model.Queries;

namespace SweetManagerWebService.Monitoring.Domain.Services.TypeRoom;

public interface ITypeRoomQueryService
{
    Task<IEnumerable<Model.Entities.TypeRoom>> Handle(GetAllTypeRoomsQuery query);
    
    Task<Model.Entities.TypeRoom?> Handle(GetTypeRoomByIdQuery query);
    
    Task<decimal?> Handle(GetMinimumPriceTypeRoomByHotelId query);
}