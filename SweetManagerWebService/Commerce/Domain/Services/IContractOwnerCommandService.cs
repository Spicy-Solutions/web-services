using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Domain.Model.Entities;

namespace SweetManagerWebService.Commerce.Domain.Services;

public interface IContractOwnerCommandService
{
    Task<ContractOwner?> Handle(CreateContractOwnerCommand command);
    Task<ContractOwner?> Handle(UpdateContractOwnerCommand command);
}