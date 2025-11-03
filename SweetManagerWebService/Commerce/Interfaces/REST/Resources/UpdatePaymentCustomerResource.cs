namespace SweetManagerWebService.Commerce.Interfaces.REST.Resources;

public record UpdatePaymentCustomerResource(int Id, int? GuestId, decimal? FinalAmount);