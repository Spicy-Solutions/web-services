namespace SweetManagerWebService.Commerce.Interfaces.REST.Resources;

public record SubscriptionResource(int Id, string Name, string? Content, decimal? Price, string Status);