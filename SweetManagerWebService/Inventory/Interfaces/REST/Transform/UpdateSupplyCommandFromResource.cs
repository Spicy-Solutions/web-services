using SweetManagerWebService.Inventory.Domain.Model.Commands;
using SweetManagerWebService.Inventory.Interfaces.REST.Resources;

namespace SweetManagerWebService.Inventory.Interfaces.REST.Transform;

public class UpdateSupplyCommandFromResource
{
    public static UpdateSupplyCommand FromResource(int Id, UpdateSupplyResource resource)
    {
        return new UpdateSupplyCommand(Id,  resource.ProviderId, resource.HotelId, resource.Name, resource.Price,resource.Stock, resource.State);
    }
}
