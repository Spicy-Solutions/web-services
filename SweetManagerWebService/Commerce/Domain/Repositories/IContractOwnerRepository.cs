using SweetManagerIotWebService.API.Commerce.Domain.Model.Entities;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerIotWebService.API.Commerce.Domain.Repositories;

public interface IContractOwnerRepository : IBaseRepository<ContractOwner>
{
    Task<IEnumerable<ContractOwner>> FindByOwnerIdAsync(int ownerId);
    
    Task<IEnumerable<ContractOwner>> FindBySubscriptionIdAsync(int subscriptionId);
}