using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.Commerce.Infrastructure.Persistence.EFC.Repositories;

public class SubscriptionRepository(SweetManagerContext context) : BaseRepository<Subscription>(context), ISubscriptionRepository
{
    public async Task<Subscription?> FindByNameAsync(ESubscriptionTypes name)
    {
        return await Context.Set<Subscription>()
            .FirstOrDefaultAsync(subscription => subscription.Name == name);
    }

    public async Task<IEnumerable<Subscription>> FindByStatusAsync(EStates status)
    {
        return await Context.Set<Subscription>().Where(subscription => subscription.Status.Equals(status)).ToListAsync();
    }
}