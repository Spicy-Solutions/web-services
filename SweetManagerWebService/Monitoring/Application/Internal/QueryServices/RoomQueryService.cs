using SweetManagerWebService.Monitoring.Domain.Model.Aggregates;
using SweetManagerWebService.Monitoring.Domain.Model.Queries;
using SweetManagerWebService.Monitoring.Domain.Repositories;
using SweetManagerWebService.Monitoring.Domain.Services.Room;

namespace SweetManagerWebService.Monitoring.Application.Internal.QueryServices;

public class RoomQueryService(IRoomRepository roomRepository) : IRoomQueryService
{
    public async Task<IEnumerable<Room>> Handle(GetAllRoomsQuery query)
    {
        return await roomRepository.FindAllByHotelIdAsync(query.HotelId);
    }

    public async Task<Room?> Handle(GetRoomsByIdQuery query)
    {
        return await roomRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Room>> Handle(GetRoomsByStateQuery query)
    {
        return await roomRepository.FindByStateAsync(query.State);
    }

    public async Task<IEnumerable<Room>> Handle(GetRoomsByTypeRoomIdQuery query)
    {
        return await roomRepository.FindByTypeRoomIdAsync(query.TypeRoomId);
    }
}