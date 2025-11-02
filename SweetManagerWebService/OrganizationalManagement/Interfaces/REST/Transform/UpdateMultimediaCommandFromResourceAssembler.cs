using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public class UpdateMultimediaCommandFromResourceAssembler
{
    public static UpdateMultimediaCommand ToCommandFromResource(UpdateMultimediaResource resource)
        => new UpdateMultimediaCommand(resource.Id,resource.HotelId, resource.Url, resource.Type, resource.Position);
}