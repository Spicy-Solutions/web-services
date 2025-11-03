namespace SweetManagerWebService.Commerce.Interfaces.REST.Resources;

public record CreateSubscriptionResource(string Name, string? Content, decimal? Price, string Status);