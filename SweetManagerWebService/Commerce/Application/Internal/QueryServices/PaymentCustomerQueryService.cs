using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Queries;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Commerce.Domain.Services;

namespace SweetManagerWebService.Commerce.Application.Internal.QueryServices;

public class PaymentCustomerQueryService(IPaymentCustomerRepository paymentCustomerRepository) : IPaymentCustomerQueryService
{
    public async Task<IEnumerable<PaymentCustomer>> Handle(GetAllPaymentCustomersQuery query)
    {
        return await paymentCustomerRepository.ListAsync();
    }

    public async Task<PaymentCustomer?> Handle(GetPaymentCustomerByIdQuery query)
    {
        return await paymentCustomerRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<PaymentCustomer>> Handle(GetAllPaymentCustomersByCustomerIdQuery query)
    {
        return await paymentCustomerRepository.FindByCustomerIdAsync(query.CustomerId);
    }
}