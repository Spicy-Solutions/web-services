namespace SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Thermostat;

public record UpdateThermostatStateResource(int Id,
    string? State);