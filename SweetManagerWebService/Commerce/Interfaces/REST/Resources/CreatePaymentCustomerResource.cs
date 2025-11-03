namespace SweetManagerWebService.Commerce.Interfaces.REST.Resources;

public record CreatePaymentCustomerResource(int? GuestId, decimal? FinalAmount);