using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class CreateContractOwnerCommandFromResourceAssembler
{
    public static CreateContractOwnerCommand ToCommandFromResource(CreateContractOwnerResource resource)
    {
        if (!Enum.TryParse<EStates>(resource.Status, true, out var status))
        {
            throw new ArgumentException($"Invalid value for Status: {resource.Status}");
        }
        
        return new CreateContractOwnerCommand(
            resource.OwnerId,
            resource.StartDate,
            resource.FinalDate,
            resource.SubscriptionId,
            status);
    }
}