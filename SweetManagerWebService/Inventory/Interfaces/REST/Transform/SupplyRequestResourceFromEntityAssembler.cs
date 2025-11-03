using SweetManagerWebService.Inventory.Domain.Model.Entities;
using SweetManagerWebService.Inventory.Interfaces.REST.Resources;

namespace SweetManagerWebService.Inventory.Interfaces.REST.Transform;

public class SupplyRequestResourceFromEntityAssembler
{
    public static SupplyRequestResource ToResourceFromEntity(SupplyRequest resource)
    {
        return new SupplyRequestResource(resource.Id, resource.PaymentOwnerId, resource.SupplyId, resource.Count,resource.Amount);
    }
}