using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Queries.Supply;

namespace SweetManagerWebService.Inventory.Domain.Services;

public interface ISupplyQueryService
{
    Task<Supply?> Handle(GetSupplyByIdQuery query);
    
    Task<IEnumerable<Supply>> Handle(GetAllSuppliesQuery query);
    
    Task<IEnumerable<Supply>> Handle(GetSupplyByProviderIdQuery query);
}