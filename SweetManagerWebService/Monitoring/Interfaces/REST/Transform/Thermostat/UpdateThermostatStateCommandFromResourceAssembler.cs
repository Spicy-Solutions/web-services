using SweetManagerWebService.Monitoring.Domain.Model.Commands.Thermostat;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Thermostat;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Thermostat;

public class UpdateThermostatStateCommandFromResourceAssembler
{
    public static UpdateThermostatStateCommand ToCommandFromResource(UpdateThermostatStateResource resource)
    {
        return new UpdateThermostatStateCommand(
            resource.Id,
            resource.State);
    }
}