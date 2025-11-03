namespace SweetManagerWebService.Commerce.Interfaces.REST.Resources;

public record PaymentOwnerResource(int Id, int? OwnerId, string? Description, decimal? FinalAmount);