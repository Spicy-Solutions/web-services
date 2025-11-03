using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class CreatePaymentOwnerCommandFromResourceAssembler
{
    public static CreatePaymentOwnerCommand ToCommandFromResource(CreatePaymentOwnerResource resource)
    {
        return new CreatePaymentOwnerCommand(
            resource.OwnerId,
            resource.Description,
            resource.FinalAmount);
    }
}