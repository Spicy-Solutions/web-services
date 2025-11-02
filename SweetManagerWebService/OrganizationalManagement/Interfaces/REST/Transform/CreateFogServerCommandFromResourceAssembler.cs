using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public static class CreateFogServerCommandFromResourceAssembler
{
    public static CreateFogServerCommand ToCommandFromResource(CreateFogServerResource resource)
    {
        return new CreateFogServerCommand(resource.IpAddress, resource.SubnetMask, resource.HotelId);
    }
}