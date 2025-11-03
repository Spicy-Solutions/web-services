using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Validation;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public class CreateHotelCommandFromResourceAssembler
{
    public static CreateHotelCommand ToCommandFromResource(CreateHotelResource resource)
    {
        CreateHotelResourceValidator.Validate(resource);
        return new CreateHotelCommand(resource.OwnerId, resource.Name, resource.Description, resource.Email, resource.Address, resource.Phone, resource.Category);
    }
}