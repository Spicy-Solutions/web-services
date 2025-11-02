using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.OrganizationalManagement.Domain.Services;

namespace SweetManagerWebService.OrganizationalManagement.Application.Internal.QueryServices;

public class ProviderQueryService(IProviderRepository providerRepository) : IProviderQueryService
{
    public async Task<Provider?> Handle(GetProviderByIdQuery query)
    {
        return await providerRepository.FindByIdAsync(query.providerId);
    }
    
    public async Task<IEnumerable<Provider>> Handle(GetAllProvidersQuery query) 
    {
        return await providerRepository.GetAllProvidersAsync(query.hotelId); // query.hotelId, it is necessary inventory bc ready for recover the providers_id by hotel_id
    }
}
