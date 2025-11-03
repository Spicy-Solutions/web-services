using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Commands;

namespace SweetManagerWebService.Commerce.Domain.Services;

public interface IPaymentOwnerCommandService
{
    Task<PaymentOwner?> Handle(CreatePaymentOwnerCommand command);
    Task<PaymentOwner?> Handle(UpdatePaymentOwnerCommand command);  
}