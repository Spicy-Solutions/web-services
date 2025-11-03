using SweetManagerWebService.Inventory.Domain.Model.Entities;
using SweetManagerWebService.Inventory.Domain.Model.Queries.SupplyRequest;

namespace SweetManagerWebService.Inventory.Domain.Services;

public interface ISupplyRequestQueryService
{
    Task<SupplyRequest?> Handle(GetSupplyRequestByIdQuery query);
    
    Task<IEnumerable<SupplyRequest>> Handle(GetAllSupplyRequestQuery query);
    
    Task<SupplyRequest?> Handle(GetSupplyRequestByPaymentOwnerIdQuery query);
    
    Task<SupplyRequest?> Handle(GetSupplyRequestBySupplyIdQuery query);
}