using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class CreatePaymentCustomerCommandFromResourceAssembler
{
    public static CreatePaymentCustomerCommand ToCommandFromResource(CreatePaymentCustomerResource resource)
    {
        return new CreatePaymentCustomerCommand(
            resource.GuestId,
            resource.FinalAmount);
    }
}