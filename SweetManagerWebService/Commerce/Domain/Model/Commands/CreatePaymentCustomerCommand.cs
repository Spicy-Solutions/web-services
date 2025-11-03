namespace SweetManagerWebService.Commerce.Domain.Model.Commands;

public record CreatePaymentCustomerCommand(int? GuestId, decimal? FinalAmount);