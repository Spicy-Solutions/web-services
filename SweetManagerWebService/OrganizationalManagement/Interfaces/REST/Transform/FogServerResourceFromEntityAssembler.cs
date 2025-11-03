using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public static class FogServerResourceFromEntityAssembler
{
    public static FogServerResource? ToResourceFromEntity(FogServer entity)
    {
        return new FogServerResource(entity.Id, entity.IpAddress, entity.SubnetMask, entity.HotelId);
    }
}