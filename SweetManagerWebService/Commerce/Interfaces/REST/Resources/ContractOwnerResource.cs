namespace SweetManagerWebService.Commerce.Interfaces.REST.Resources;

public record ContractOwnerResource(int Id, int? OwnerId, DateTime? StartDate, DateTime? FinalDate, 
    int? SubscriptionId, string Status);