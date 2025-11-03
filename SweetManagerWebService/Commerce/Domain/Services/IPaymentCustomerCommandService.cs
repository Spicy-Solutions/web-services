using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Commands;

namespace SweetManagerWebService.Commerce.Domain.Services;

public interface IPaymentCustomerCommandService
{
    Task<PaymentCustomer?> Handle(CreatePaymentCustomerCommand command);
    Task<PaymentCustomer?> Handle(UpdatePaymentCustomerCommand command);
}