
using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Interfaces.REST.Resources;

namespace SweetManagerWebService.Inventory.Interfaces.REST.Transform;

public class SupplyResourceFromEntityAssembler
{
    public static SupplyResource ToResourceFromEntity(Supply supply)
    {
        return new SupplyResource(supply.Id, supply.ProviderId, supply.HotelId, supply.Name, supply.Price, supply.Stock, supply.State);
    }
}

