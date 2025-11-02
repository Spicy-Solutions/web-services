using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Infrastructure.Persistence.EFC.Repositories;

public class ProviderRepository(SweetManagerContext context) : BaseRepository<Provider>(context), IProviderRepository
{
    public async Task<IEnumerable<Provider>> GetAllProvidersAsync(int hotelId)
        => await Context.Set<Provider>().Where(p => p.HotelId.Equals(hotelId)).ToListAsync();
    
}