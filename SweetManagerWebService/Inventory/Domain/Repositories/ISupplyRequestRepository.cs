using SweetManagerWebService.Inventory.Domain.Model.Entities;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Inventory.Domain.Repositories;

public interface ISupplyRequestRepository: IBaseRepository<SupplyRequest>
{
    public Task<SupplyRequest?> FindBySupplyId(int supplyId);
    
    public Task<SupplyRequest?> FindByPaymentOwnerId(int paymentOwnerId);

    public Task<IEnumerable<SupplyRequest>> FindAllSuppliesRequestsAsync(int HotelId);
}