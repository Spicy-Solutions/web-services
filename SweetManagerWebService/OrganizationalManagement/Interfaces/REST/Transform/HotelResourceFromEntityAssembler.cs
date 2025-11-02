using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public class HotelResourceFromEntityAssembler
{
    public static HotelResource ToResourceFromEntity(Hotel entity)
    {
        return new HotelResource(entity.Id, entity.Name, entity.Description, entity.Email, entity.Address, entity.Phone, entity.OwnerId, entity.Category.ToString());
    }
}