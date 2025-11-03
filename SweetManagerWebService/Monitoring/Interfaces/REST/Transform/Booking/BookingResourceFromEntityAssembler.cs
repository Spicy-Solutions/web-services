using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Booking;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Booking;

public class BookingResourceFromEntityAssembler
{
    public static BookingResource ToResourceFromEntity(Domain.Model.Aggregates.Booking booking)
    {
        return new BookingResource(
            booking.Id,
            booking.PaymentCustomerId,
            booking.RoomId,
            booking.Description,
            booking.StartDate,
            booking.FinalDate,
            booking.PriceRoom,
            booking.NightCount,
            booking.Amount,
            booking.State,
            booking.PreferenceId);
    }
}
