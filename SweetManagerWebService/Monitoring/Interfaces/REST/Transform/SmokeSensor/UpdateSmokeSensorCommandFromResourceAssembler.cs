using SweetManagerWebService.Monitoring.Domain.Model.Commands.SmokeSensor;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.SmokeSensor;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.SmokeSensor;

public class UpdateSmokeSensorCommandFromResourceAssembler
{
    public static UpdateSmokeSensorCommand ToCommandFromResource(UpdateSmokeSensorResource resource)
    {
        return new UpdateSmokeSensorCommand(
            resource.Id,
            resource.RoomId,
            resource.LastAnalogicValue,
            resource.IpAddress,
            resource.MacAddress,
            resource.State,
            resource.LastAlertTime
        );
    }
}