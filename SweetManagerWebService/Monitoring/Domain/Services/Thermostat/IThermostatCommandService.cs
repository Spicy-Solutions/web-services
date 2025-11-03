using SweetManagerWebService.Monitoring.Domain.Model.Commands.Thermostat;

namespace SweetManagerWebService.Monitoring.Domain.Services.Thermostat;

public interface IThermostatCommandService
{
    Task<bool> Handle(CreateThermostatCommand command);
    Task<bool> Handle(UpdateThermostatStateCommand command);
    
    Task<bool> Handle(UpdateThermostatTemperatureCommand command);
    Task<bool> Handle(UpdateThermostatCommand command);
}