using SweetManagerWebService.Monitoring.Domain.Model.Entities;
using SweetManagerWebService.Monitoring.Domain.Model.Queries;
using SweetManagerWebService.Monitoring.Domain.Repositories;
using SweetManagerWebService.Monitoring.Domain.Services.TypeRoom;

namespace SweetManagerWebService.Monitoring.Application.Internal.QueryServices;

public class TypeRoomQueryServices(ITypeRoomRepository typeRoomRepository) : ITypeRoomQueryService
{
    public Task<IEnumerable<TypeRoom>> Handle(GetAllTypeRoomsQuery query)
    {
        return typeRoomRepository.FindAllByHotelIdAsync(query.HotelId);
    }

    public Task<TypeRoom?> Handle(GetTypeRoomByIdQuery query)
    {
        return typeRoomRepository.FindByIdAsync(query.Id);
    }
    
    public async Task<decimal?> Handle(GetMinimumPriceTypeRoomByHotelId query)
    {
        var typeRooms = await typeRoomRepository.FindAllByHotelIdAsync(query.hotelId);
        return typeRooms.Min(tr => tr.Price);
    }

}