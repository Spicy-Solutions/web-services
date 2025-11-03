using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Infrastructure.Persistence.EFC.Repositories;

public class HotelRepository(SweetManagerContext context) : BaseRepository<Hotel>(context), IHotelRepository
{
    public async Task<Hotel?> FindByNameAndEmailAsync(string name, string email)
    {
        return await Context.Set<Hotel>()
            .Where(h => h.Name == name && h.Email == email)
            .FirstOrDefaultAsync();
    }
    
    public async Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    {
        return await Context.Set<Hotel>()
            .ToListAsync();
    }

    public async Task<IEnumerable<Hotel>> FindByOwnerIdAsync(int ownerId)
    {
        return await Context.Set<Hotel>()
            .Where(h => h.OwnerId == ownerId)
            .ToListAsync();
    }
}