using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public static class UpdateFogServerCommandFromResourceAssembler
{
    public static UpdateFogServerCommand ToCommandFromResource(int Id, UpdateFogServerResource resource)
    {
        return new UpdateFogServerCommand(Id, resource.IpAddress, resource.SubnetMask);
    }
}