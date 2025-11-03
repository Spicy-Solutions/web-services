using SweetManagerWebService.Commerce.Domain.Model.Entities;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Commerce.Domain.Repositories;

public interface IContractOwnerRepository : IBaseRepository<ContractOwner>
{
    Task<IEnumerable<ContractOwner>> FindByOwnerIdAsync(int ownerId);
    
    Task<IEnumerable<ContractOwner>> FindBySubscriptionIdAsync(int subscriptionId);
}