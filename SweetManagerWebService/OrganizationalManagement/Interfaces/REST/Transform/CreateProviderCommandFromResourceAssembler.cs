using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public class CreateProviderCommandFromResourceAssembler
{
    public static CreateProviderCommand ToCommandFromResource(CreateProviderResource resource)
    {
        return new CreateProviderCommand(resource.Name, resource.Email, resource.Phone, resource.State, resource.HotelId);
    }
}