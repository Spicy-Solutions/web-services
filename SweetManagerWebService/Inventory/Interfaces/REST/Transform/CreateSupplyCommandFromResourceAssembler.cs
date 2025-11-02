using SweetManagerWebService.Inventory.Domain.Model.Commands;
using SweetManagerWebService.Inventory.Interfaces.REST.Resources;


namespace SweetManagerWebService.Inventory.Interfaces.REST.Transform;

public class CreateSupplyCommandFromResourceAssembler
{
    public static CreateSupplyCommand ToCommandFromResource(CreateSupplyResource resource)
    {
        return new CreateSupplyCommand(resource.ProviderId, resource.HotelId, resource.Name, resource.Price, resource.Stock, resource.State);
    }
}