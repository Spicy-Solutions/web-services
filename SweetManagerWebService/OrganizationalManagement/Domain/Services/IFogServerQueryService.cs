using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Services;

public interface IFogServerQueryService
{
    Task<FogServer?> Handle(GetFogServerByHotelIdQuery query);

    Task<FogServer?> Handle(GetFogServerByIdQuery query);   
}