using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;

namespace SweetManagerWebService.Commerce.Domain.Model.Commands;

public record UpdateContractOwnerCommand(
    int Id,
    int? OwnerId,
    DateTime? StartDate,
    DateTime? FinalDate,
    int? SubscriptionId,
    EStates Status);