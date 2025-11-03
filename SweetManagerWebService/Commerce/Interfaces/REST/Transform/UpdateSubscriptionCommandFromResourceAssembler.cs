using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class UpdateSubscriptionCommandFromResourceAssembler
{
    public static UpdateSubscriptionCommand ToCommandFromResource(UpdateSubscriptionResource resource)
    {
        if (!Enum.TryParse<ESubscriptionTypes>(resource.Name, true, out var name))
        {
            throw new ArgumentException($"Invalid value for Subscription type: {resource.Name}");
        }
        
        if (!Enum.TryParse<EStates>(resource.Status, true, out var status))
        {
            throw new ArgumentException($"Invalid value for Status: {resource.Status}");
        }
        
        return new UpdateSubscriptionCommand(
            resource.Id,
            name,
            resource.Content,
            resource.Price,
            status);
    }
}