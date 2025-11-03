using SweetManagerWebService.Monitoring.Domain.Model.Commands.SmokeSensor;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.SmokeSensor;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.SmokeSensor;

public class UpdatSmokeSensorAnalogicValueCommandFromResourceAssembler
{
    public static UpdatSmokeSensorAnalogicValueCommand ToCommandFromResource(UpdateSmokeSensorAnalogicValueResource resource)
    {
        return new UpdatSmokeSensorAnalogicValueCommand(
            resource.Id,
            resource.LastAnalogicValue);
    }
}