using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public class UpdateHotelCommandFromResourceAssembler
{
    public static UpdateHotelCommand ToCommandFromResource(int id, UpdateHotelResource resource)
    {
        return new UpdateHotelCommand(id, resource.Description, resource.Email, resource.Address, resource.Phone, resource.OwnerId, resource.Category);
    }
}