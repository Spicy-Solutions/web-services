namespace SweetManagerWebService.Monitoring.Interfaces.REST.Resources.SmokeSensor;

public record UpdateSmokeSensorStateResource(int Id,
    string? State);