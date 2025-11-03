namespace SweetManagerWebService.Monitoring.Interfaces.REST.Resources.SmokeSensor;

public record UpdateSmokeSensorAnalogicValueResource(int Id,
    double? LastAnalogicValue);