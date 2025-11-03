using SweetManagerWebService.Monitoring.Domain.Model.Entities;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Monitoring.Domain.Repositories;

public interface ITypeRoomRepository : IBaseRepository<TypeRoom>
{
    Task <IEnumerable<TypeRoom>> FindAllByHotelIdAsync(int? hotelId);
}