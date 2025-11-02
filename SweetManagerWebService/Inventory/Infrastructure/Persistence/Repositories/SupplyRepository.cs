using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Entities;
using SweetManagerWebService.Inventory.Domain.Repositories;
using SweetManagerWebService.OrganizationalManagement.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerIotWebService.Inventory.Infrastructure.Persistence.Repositories;

public class SupplyRepository(SweetManagerContext context) : BaseRepository<Supply>(context), ISupplyRepository
{

    public async Task<bool> ExecuteUpdateProviderIdAsync(int id, int providerId)
     => await Context.Set<Supply>().Where(s => s.Id.Equals(id))
        .ExecuteUpdateAsync(s => s.SetProperty(u => u.ProviderId, providerId)) > 0;

    public async Task<IEnumerable<Supply>> FindByProviderId(int providerId)
    {
        return await Context.Set<Supply>().Where(s => s.ProviderId == providerId).ToListAsync();
    }
    
    public async Task<IEnumerable<Supply>> FindSuppliesByHotelIdAsync(int hotelId)
    {
        return await Context.Set<Supply>()
            .Where(s => s.HotelId == hotelId)
            .ToListAsync();
    }
}