using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class PaymentCustomerResourceFromEntityAssembler
{
    public static PaymentCustomerResource ToResourceFromEntity(PaymentCustomer paymentCustomer)
    {
        return new PaymentCustomerResource(
            paymentCustomer.Id,
            paymentCustomer.GuestId,
            paymentCustomer.FinalAmount);
    }
}