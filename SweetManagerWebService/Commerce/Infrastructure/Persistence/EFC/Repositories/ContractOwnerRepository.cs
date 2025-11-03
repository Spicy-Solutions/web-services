using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Commerce.Domain.Model.Entities;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.Commerce.Infrastructure.Persistence.EFC.Repositories;

public class ContractOwnerRepository(SweetManagerContext context) : BaseRepository<ContractOwner>(context), IContractOwnerRepository
{
    public async Task<IEnumerable<ContractOwner>> FindByOwnerIdAsync(int ownerId)
    {
        return await Context.Set<ContractOwner>().Where(contractOwner => contractOwner.OwnerId.Equals(ownerId)).ToListAsync();
    }

    public async Task<IEnumerable<ContractOwner>> FindBySubscriptionIdAsync(int subscriptionId)
    {
        return await Context.Set<ContractOwner>().Where(contractOwner => contractOwner.SubscriptionId.Equals(subscriptionId)).ToListAsync();
    }
}