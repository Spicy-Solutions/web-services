
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Repositories;

public interface IProviderRepository : IBaseRepository<Provider>
{
    Task<IEnumerable<Provider>> GetAllProvidersAsync(int hotelId);
}