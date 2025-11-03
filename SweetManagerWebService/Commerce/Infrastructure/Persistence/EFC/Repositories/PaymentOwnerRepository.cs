using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.Commerce.Infrastructure.Persistence.EFC.Repositories;

public class PaymentOwnerRepository(SweetManagerContext context) : BaseRepository<PaymentOwner>(context), IPaymentOwnerRepository
{
    public async Task<IEnumerable<PaymentOwner>> FindByOwnerIdAsync(int ownerId)
    {
        return await Context.Set<PaymentOwner>().Where(paymentOwner => paymentOwner.OwnerId.Equals(ownerId)).ToListAsync();
    }
}