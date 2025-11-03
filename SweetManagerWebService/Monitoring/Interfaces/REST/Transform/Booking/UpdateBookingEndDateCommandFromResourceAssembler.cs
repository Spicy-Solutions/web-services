using SweetManagerWebService.Monitoring.Domain.Model.Commands.Booking;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Booking;

public class UpdateBookingEndDateCommandFromResourceAssembler
{
    public static UpdateBookingEndDateCommand ToCommandFromResource(UpdateBookingEndDateCommand resource)
    {
        return new UpdateBookingEndDateCommand(resource.Id, resource.EndDate);
    }
}