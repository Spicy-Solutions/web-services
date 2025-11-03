namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.Thermostat;

public record UpdateThermostatTemperatureCommand(int Id,
    double? Temperature);