using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public static class MultimediaResourceFromEntityAssembler
{
    public static MultimediaResource ToResourceFromEntity(Multimedia entity)
        => new MultimediaResource(entity.Id, entity.HotelId, entity.Url, entity.Type.ToString(), entity.Position);
}