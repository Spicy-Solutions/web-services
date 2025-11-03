using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Infrastructure.Persistence.EFC.Repositories;

public class FogServerRepository(SweetManagerContext context) : BaseRepository<FogServer>(context), IFogServerRepository
{
    public async Task<FogServer?> FindByHotelIdAsync(int hotelId)
        => await Context.Set<FogServer>().Where(a => a.HotelId.Equals(hotelId)).FirstOrDefaultAsync(); 
}