using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Commands;

namespace SweetManagerWebService.Commerce.Domain.Services;

public interface ISubscriptionCommandService
{
    Task<Subscription?> Handle(CreateSubscriptionCommand command);
    Task<Subscription?> Handle(UpdateSubscriptionCommand command);
    Task<bool> Handle(SeedSubscriptionsCommand command);
}