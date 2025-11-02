using SweetManagerWebService.Shared.Domain.Repositories;
using SweetManagerWebService.Inventory.Domain.Model.Aggregates;

namespace SweetManagerWebService.Inventory.Domain.Repositories;

public interface ISupplyRepository : IBaseRepository<Supply>
{
    public Task<IEnumerable<Supply>> FindByProviderId(int providerId);
    
    public Task<IEnumerable<Supply>> FindSuppliesByHotelIdAsync(int hotelId);

    public Task<bool> ExecuteUpdateProviderIdAsync(int id, int providerId);
}