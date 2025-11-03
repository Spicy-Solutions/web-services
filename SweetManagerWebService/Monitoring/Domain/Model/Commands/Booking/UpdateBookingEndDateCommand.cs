namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.Booking;

public record UpdateBookingEndDateCommand(int Id, DateTime EndDate);