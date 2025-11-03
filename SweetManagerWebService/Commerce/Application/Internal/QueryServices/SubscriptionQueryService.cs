using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Queries;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Commerce.Domain.Services;

namespace SweetManagerWebService.Commerce.Application.Internal.QueryServices;

public class SubscriptionQueryService(ISubscriptionRepository subscriptionRepository) : ISubscriptionQueryService
{
    public async Task<IEnumerable<Subscription>> Handle(GetAllSubscriptionsQuery query)
    {
        return await subscriptionRepository.ListAsync();
    }

    public async Task<Subscription?> Handle(GetSubscriptionByIdQuery query)
    {
        return await subscriptionRepository.FindByIdAsync(query.Id);
    }

    public async Task<Subscription?> Handle(GetAllSubscriptionsByNameQuery query)
    {
        return await subscriptionRepository.FindByNameAsync(query.Name);
    }

    public async Task<IEnumerable<Subscription>> Handle(GetAllSubscriptionsByStatusQuery query)
    {
        return await subscriptionRepository.FindByStatusAsync(query.Status);
    }
}