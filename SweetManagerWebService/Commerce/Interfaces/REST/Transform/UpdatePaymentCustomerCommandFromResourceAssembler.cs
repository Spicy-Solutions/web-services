using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class UpdatePaymentCustomerCommandFromResourceAssembler
{
    public static UpdatePaymentCustomerCommand ToCommandFromResource(UpdatePaymentCustomerResource resource)
    {
        return new UpdatePaymentCustomerCommand(
            resource.Id,
            resource.GuestId,
            resource.FinalAmount);
    }
}