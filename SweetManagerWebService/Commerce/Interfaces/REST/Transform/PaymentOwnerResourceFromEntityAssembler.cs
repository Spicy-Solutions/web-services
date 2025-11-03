using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class PaymentOwnerResourceFromEntityAssembler
{
    public static PaymentOwnerResource ToResourceFromEntity(PaymentOwner paymentOwner)
    {
        return new PaymentOwnerResource(
            paymentOwner.Id,
            paymentOwner.OwnerId,
            paymentOwner.Description,
            paymentOwner.FinalAmount);
    }
}