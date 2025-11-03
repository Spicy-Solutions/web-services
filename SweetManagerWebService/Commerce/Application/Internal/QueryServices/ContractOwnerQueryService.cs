using SweetManagerWebService.Commerce.Domain.Model.Entities;
using SweetManagerWebService.Commerce.Domain.Model.Queries;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Commerce.Domain.Services;

namespace SweetManagerWebService.Commerce.Application.Internal.QueryServices;

public class ContractOwnerQueryService(IContractOwnerRepository contractOwnerRepository) : IContractOwnerQueryService
{
    public async Task<IEnumerable<ContractOwner>> Handle(GetAllContractOwnersQuery query)
    {
        return await contractOwnerRepository.ListAsync();
    }

    public async Task<ContractOwner?> Handle(GetContractOwnerByIdQuery query)
    {
        return await contractOwnerRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<ContractOwner>> Handle(GetAllContractOwnersByOwnerIdQuery query)
    {
        return await contractOwnerRepository.FindByOwnerIdAsync(query.OwnerId);
    }

    public async Task<IEnumerable<ContractOwner>> Handle(GetAllContractOwnersBySubscriptionIdQuery query)
    {
        return await contractOwnerRepository.FindBySubscriptionIdAsync(query.SubscriptionId);
    }
}