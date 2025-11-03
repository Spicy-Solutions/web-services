using SweetManagerWebService.Monitoring.Domain.Model.Commands.Thermostat;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Thermostat;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Thermostat;

public class UpdateThermostatCommandFromResourceAssembler
{
    public static UpdateThermostatCommand ToCommandFromResource(UpdateThermostatResource resource)
    {
        return new UpdateThermostatCommand(
            resource.Id,
            resource.RoomId,
            resource.Temperature,
            resource.IpAddress,
            resource.MacAddress,
            resource.State,
            resource.LastUpdate
        );
    }
}