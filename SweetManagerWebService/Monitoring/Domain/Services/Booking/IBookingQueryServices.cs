using SweetManagerWebService.Monitoring.Domain.Model.Aggregates;
using SweetManagerWebService.Monitoring.Domain.Model.Queries;

namespace SweetManagerWebService.Monitoring.Domain.Services.Booking;

public interface IBookingQueryServices
{
    Task<IEnumerable<Model.Aggregates.Booking>> Handle(GetAllBookingsQuery query);
    Task<IEnumerable<BookingDto>> Handle(GetBookingByCustomerIdQuery query);
    Task<IEnumerable<Model.Aggregates.Booking>> Handle(GetBookingByHotelIdAndState query);
    Task<Model.Aggregates.Booking?> Handle(GetBookingByIdQuery query);
}