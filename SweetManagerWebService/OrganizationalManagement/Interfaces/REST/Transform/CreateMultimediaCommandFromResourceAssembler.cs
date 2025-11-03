using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public static class CreateMultimediaCommandFromResourceAssembler
{
    public static CreateMultimediaCommand ToCommandFromResource(CreateMultimediaResource resource)
        => new CreateMultimediaCommand(resource.HotelId, resource.Url, resource.Type, resource.Position);
}