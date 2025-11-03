using SweetManagerWebService.Monitoring.Domain.Model.Commands.SmokeSensor;

namespace SweetManagerWebService.Monitoring.Domain.Services.SmokeSensor;

public interface ISmokeSensorCommandService
{
    Task<bool> Handle(CreateSmokeSensorCommand command);
    Task<bool> Handle(UpdateSmokeSensorStateCommand command);
    
    Task<bool> Handle(UpdatSmokeSensorAnalogicValueCommand command);
    Task<bool> Handle(UpdateSmokeSensorCommand command);
}