using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.OrganizationalManagement.Domain.Services;

namespace SweetManagerWebService.OrganizationalManagement.Application.Internal.QueryServices;

public class FogServerQueryService(IFogServerRepository fogServerRepository) : IFogServerQueryService
{
    public async Task<FogServer?> Handle(GetFogServerByHotelIdQuery query)
        => await fogServerRepository.FindByHotelIdAsync(query.HotelId);

    public async Task<FogServer?> Handle(GetFogServerByIdQuery query)
        => await fogServerRepository.FindByIdAsync(query.Id);

}