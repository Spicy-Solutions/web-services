using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class UpdatePaymentOwnerCommandFromResourceAssembler
{
    public static UpdatePaymentOwnerCommand ToCommandFromResource(UpdatePaymentOwnerResource resource)
    {
        return new UpdatePaymentOwnerCommand(
            resource.Id,
            resource.OwnerId,
            resource.Description,
            resource.FinalAmount);
    }
}