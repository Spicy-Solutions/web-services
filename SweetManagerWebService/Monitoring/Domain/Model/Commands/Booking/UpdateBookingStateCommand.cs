namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.Booking;

public record UpdateBookingStateCommand(int Id, string State);