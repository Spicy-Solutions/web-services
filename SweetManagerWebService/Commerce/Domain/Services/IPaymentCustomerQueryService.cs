using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Queries;

namespace SweetManagerWebService.Commerce.Domain.Services;

public interface IPaymentCustomerQueryService
{
    Task<IEnumerable<PaymentCustomer>> Handle(GetAllPaymentCustomersQuery query);
    Task<PaymentCustomer?> Handle(GetPaymentCustomerByIdQuery query);
    Task<IEnumerable<PaymentCustomer>> Handle(GetAllPaymentCustomersByCustomerIdQuery query);
}