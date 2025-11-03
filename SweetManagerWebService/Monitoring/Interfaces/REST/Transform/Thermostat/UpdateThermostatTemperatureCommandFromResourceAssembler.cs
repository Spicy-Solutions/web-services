using SweetManagerWebService.Monitoring.Domain.Model.Commands.Thermostat;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Thermostat;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Thermostat;

public class UpdateThermostatTemperatureCommandFromResourceAssembler
{
    public static UpdateThermostatTemperatureCommand ToCommandFromResource(UpdateThermostatTemperatureResource resource)
    {
        return new UpdateThermostatTemperatureCommand(
            resource.Id,
            resource.Temperature);
    }
}