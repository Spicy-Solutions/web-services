using SweetManagerWebService.Commerce.Domain.Model.Entities;
using SweetManagerWebService.Commerce.Domain.Model.Queries;

namespace SweetManagerWebService.Commerce.Domain.Services;

public interface IContractOwnerQueryService
{
    Task<IEnumerable<ContractOwner>> Handle(GetAllContractOwnersQuery query);
    Task<ContractOwner?> Handle(GetContractOwnerByIdQuery query);
    Task<IEnumerable<ContractOwner>> Handle(GetAllContractOwnersByOwnerIdQuery query);
    Task<IEnumerable<ContractOwner>> Handle(GetAllContractOwnersBySubscriptionIdQuery query);
}