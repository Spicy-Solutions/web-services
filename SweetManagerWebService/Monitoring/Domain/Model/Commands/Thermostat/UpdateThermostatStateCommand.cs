namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.Thermostat;

public record UpdateThermostatStateCommand(int Id,
    string? State);