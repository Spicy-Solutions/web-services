using SweetManagerWebService.Monitoring.Domain.Model.Commands.Booking;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Booking;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Booking;

public class UpdateBookingStateCommandFromResourceAssembler
{
    public static UpdateBookingStateCommand ToCommandFromResource(UpdateBookingStateResource resource)
    {
        return new UpdateBookingStateCommand(resource.Id, resource.State);
    }
}