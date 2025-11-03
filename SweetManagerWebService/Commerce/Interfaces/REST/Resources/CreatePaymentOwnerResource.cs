namespace SweetManagerWebService.Commerce.Interfaces.REST.Resources;

public record CreatePaymentOwnerResource(int? OwnerId, string? Description, decimal? FinalAmount);