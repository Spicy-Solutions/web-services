using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Repositories;

public interface IFogServerRepository : IBaseRepository<FogServer>
{
    Task<FogServer?> FindByHotelIdAsync(int hotelId);
}