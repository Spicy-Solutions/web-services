using SweetManagerWebService.Monitoring.Domain.Model.Commands.SmokeSensor;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.SmokeSensor;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.SmokeSensor;

public class CreateSmokeSensorCommandFromResourceAssembler
{
    public static CreateSmokeSensorCommand ToCommandFromResource(CreateSmokeSensorResource resource)
    {
        return new CreateSmokeSensorCommand(
            resource.RoomId,
            resource.LastAnalogicValue,
            resource.IpAddress,
            resource.MacAddress,
            resource.State,
            resource.LastAlertTime
        );
    }
}