using SweetManagerWebService.Monitoring.Domain.Model.Commands.Thermostat;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Thermostat;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Thermostat;

public class CreateThermostatCommandFromResourceAssembler
{
    public static CreateThermostatCommand ToCommandFromResource(CreateThermostatResource resource)
    {
        return new CreateThermostatCommand(
            resource.RoomId,
            resource.Temperature,
            resource.IpAddress,
            resource.MacAddress,
            resource.State,
            resource.LastUpdate
        );
    }
}