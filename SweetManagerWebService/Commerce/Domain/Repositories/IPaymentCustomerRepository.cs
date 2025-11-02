using SweetManagerIotWebService.API.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerIotWebService.API.Commerce.Domain.Repositories;

public interface IPaymentCustomerRepository : IBaseRepository<PaymentCustomer>
{
    Task<IEnumerable<PaymentCustomer>> FindByCustomerIdAsync(int customerId);
}