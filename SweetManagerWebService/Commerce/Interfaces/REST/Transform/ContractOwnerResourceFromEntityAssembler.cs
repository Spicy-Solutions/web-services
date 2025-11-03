using Microsoft.OpenApi.Extensions;
using SweetManagerWebService.Commerce.Domain.Model.Entities;
using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class ContractOwnerResourceFromEntityAssembler
{
    public static ContractOwnerResource ToResourceFromEntity(ContractOwner contractOwner)
    {
        return new ContractOwnerResource(
            contractOwner.Id,
            contractOwner.OwnerId,
            contractOwner.StartDate,
            contractOwner.FinalDate,
            contractOwner.SubscriptionId,
            contractOwner.Status.GetDisplayName());
    }
}