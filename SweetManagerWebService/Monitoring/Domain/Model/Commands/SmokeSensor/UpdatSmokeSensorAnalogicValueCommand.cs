namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.SmokeSensor;

public record UpdatSmokeSensorAnalogicValueCommand(int Id,
    double? LastAnalogicValue);