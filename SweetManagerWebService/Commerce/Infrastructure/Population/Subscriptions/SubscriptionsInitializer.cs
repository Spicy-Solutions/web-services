using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Domain.Model.Queries;
using SweetManagerWebService.Commerce.Domain.Services;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace SweetManagerWebService.Commerce.Infrastructure.Population.Subscriptions;

public class SubscriptionsInitializer(ISubscriptionCommandService subscriptionCommandService, ISubscriptionQueryService subscriptionQueryService,
    SweetManagerContext context)
{
    public async Task InitializeAsync()
    {
        // Check if the subscription table is empty
        var result = await subscriptionQueryService.Handle(new GetAllSubscriptionsQuery());

        if (!result.Any())
        {
            // Prepopulate the empty table
            await subscriptionCommandService.Handle(new SeedSubscriptionsCommand());
        }
    }
}