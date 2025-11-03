using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.Commerce.Infrastructure.Persistence.EFC.Repositories;

public class PaymentCustomerRepository(SweetManagerContext context) : BaseRepository<PaymentCustomer>(context), IPaymentCustomerRepository
{
    public async Task<IEnumerable<PaymentCustomer>> FindByCustomerIdAsync(int customerId)
    {
        return await Context.Set<PaymentCustomer>().Where(paymentCustomer => paymentCustomer.GuestId.Equals(customerId)).ToListAsync();
    }
}