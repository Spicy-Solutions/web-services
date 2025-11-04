using SweetManagerWebService.Monitoring.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Monitoring.Domain.Repositories;

public interface IRoomRepository : IBaseRepository<Room>
{
    Task<IEnumerable<Room>> FindAllByHotelIdAsync(int? hotelId);

    Task<IEnumerable<Room>> FindByStateAsync(string? state);

    Task<IEnumerable<Room>> FindByTypeRoomIdAsync(int typeroomid);

    Task<bool> UpdateRoomStateAsync(int id, string state);
}