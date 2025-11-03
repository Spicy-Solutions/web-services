using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;

namespace SweetManagerWebService.Commerce.Domain.Model.Commands;

public record CreateContractOwnerCommand(
    int? OwnerId,
    DateTime? StartDate,
    DateTime? FinalDate,
    int? SubscriptionId,
    EStates Status);