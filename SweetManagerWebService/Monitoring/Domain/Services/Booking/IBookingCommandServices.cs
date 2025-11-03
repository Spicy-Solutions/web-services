using SweetManagerWebService.Monitoring.Domain.Model.Commands.Booking;

namespace SweetManagerWebService.Monitoring.Domain.Services.Booking;

public interface IBookingCommandServices
{
    Task<bool> Handle(CreateBookingCommand command);
    Task<bool> Handle(UpdateBookingStateCommand command);
    Task<bool> Handle(UpdateBookingEndDateCommand command);
}