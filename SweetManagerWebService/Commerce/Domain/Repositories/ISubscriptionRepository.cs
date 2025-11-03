using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Commerce.Domain.Repositories;

public interface ISubscriptionRepository : IBaseRepository<Subscription>
{
    Task<Subscription?> FindByNameAsync(ESubscriptionTypes name);
    
    Task<IEnumerable<Subscription>> FindByStatusAsync(EStates status);
}