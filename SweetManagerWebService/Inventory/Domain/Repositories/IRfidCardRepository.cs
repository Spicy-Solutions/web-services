using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Inventory.Domain.Repositories;

public interface IRfidCardRepository: IBaseRepository<RfidCard>
{
    Task<IEnumerable<RfidCard>> FindByHotelIdAsync(int hotelId);
}