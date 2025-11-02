using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Transform;

public class ProviderResourceFromEntityAssembler
{
    public static ProviderResource ToResourceFromEntity(Provider entity)
    {
        return new ProviderResource(entity.Id, entity.Name, entity.Email, entity.Phone, entity.State.ToString().ToLower());
    }
}