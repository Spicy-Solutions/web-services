namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.SmokeSensor;

public record UpdateSmokeSensorStateCommand(int Id,
    string? State);