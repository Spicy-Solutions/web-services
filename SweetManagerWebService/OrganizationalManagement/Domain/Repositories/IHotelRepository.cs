using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Repositories;

public interface IHotelRepository : IBaseRepository<Hotel>
{
    Task<Hotel?> FindByNameAndEmailAsync(string name, string email);
    Task<IEnumerable<Hotel>> GetAllHotelsAsync();
    Task<IEnumerable<Hotel>> FindByOwnerIdAsync(int ownerId);
}