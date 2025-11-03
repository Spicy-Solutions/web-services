using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Commerce.Domain.Repositories;

public interface IPaymentCustomerRepository : IBaseRepository<PaymentCustomer>
{
    Task<IEnumerable<PaymentCustomer>> FindByCustomerIdAsync(int customerId);
}