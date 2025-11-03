using SweetManagerWebService.Monitoring.Domain.Model.Commands.Booking;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Booking;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Booking;

public class CreateBookingCommandFromResourceAssembler
{
    public static CreateBookingCommand ToCommandFromResource(CreateBookingResource resource)
    {
        return new CreateBookingCommand(resource.PaymentCustomerId,
            resource.RoomId, resource.Description, resource.StartDate,
            resource.FinalDate, resource.PriceRoom, resource.NightCount, resource.Amount, resource.State,
            resource.PreferenceId);
    }
}