using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Entities;
using SweetManagerWebService.Inventory.Domain.Repositories;
using SweetManagerWebService.OrganizationalManagement.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.Inventory.Infrastructure.Persistence.Repositories;

public class SupplyRequestRepository(SweetManagerContext context) : BaseRepository<SupplyRequest>(context), ISupplyRequestRepository
{
    public async Task<SupplyRequest?> FindBySupplyId(int supplyId)
    {
        return await Context.Set<SupplyRequest>().FirstOrDefaultAsync(f => f.SupplyId == supplyId);
    }

    public async Task<SupplyRequest?> FindByPaymentOwnerId(int paymentOwnerId)
    {
        return await Context.Set<SupplyRequest>().FirstOrDefaultAsync(f => f.PaymentOwnerId == paymentOwnerId);
    }
    
    public async Task<IEnumerable<SupplyRequest>> FindAllSuppliesRequestsAsync(int queryHotelId)
    {
        return await Task.Run(() => (
            from sp in Context.Set<SupplyRequest>().ToList()
            join po in Context.Set<PaymentOwner>().ToList() on sp.PaymentOwnerId equals po.Id
            join ow in Context.Set<Owner>().ToList() on po.OwnerId equals ow.Id
            join ho in Context.Set<Hotel>().ToList() on ow.Id equals ho.OwnerId
            where ho.Id.Equals(queryHotelId)
            select sp
        ).ToList());
    }
}