
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Services;

public interface IProviderQueryService
{
    Task<Provider?> Handle(GetProviderByIdQuery query);
    Task<IEnumerable<Provider>> Handle(GetAllProvidersQuery query);
}