using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.SmokeSensor;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.SmokeSensor;

public class SmokeSensorResourceFromEntityAssembler
{
    public static SmokeSensorResource FromEntity(Domain.Model.Aggregates.SmokeSensor SmokeSensor)
    {
        return new SmokeSensorResource(
            SmokeSensor.Id,
            SmokeSensor.RoomId,
            SmokeSensor.IpAddress,
            SmokeSensor.MacAddress,
            SmokeSensor.LastAnalogicValue,
            SmokeSensor.State,
            SmokeSensor.LastAlertTime);
    }
}