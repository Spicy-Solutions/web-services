using SweetManagerWebService.Inventory.Domain.Model.Commands;
using SweetManagerWebService.Inventory.Interfaces.REST.Resources;


namespace SweetManagerWebService.Inventory.Interfaces.REST.Transform;

public class CreateSupplyRequestCommandFromResourceAssembler
{
    public static CreateSupplyRequestCommand ToCommandFromResource(CreateSupplyRequestResource resource)
    {
        return new CreateSupplyRequestCommand(
            resource.PaymentOwnerId,
            resource.SupplyId,
            resource.Count,
            resource.Amount
        );
    }
}