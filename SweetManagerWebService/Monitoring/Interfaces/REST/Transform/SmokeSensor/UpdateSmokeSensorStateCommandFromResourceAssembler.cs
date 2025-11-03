using SweetManagerWebService.Monitoring.Domain.Model.Commands.SmokeSensor;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.SmokeSensor;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.SmokeSensor;

public class UpdateSmokeSensorStateCommandFromResourceAssembler
{
    public static UpdateSmokeSensorStateCommand ToCommandFromResource(UpdateSmokeSensorStateResource resource)
    {
        return new UpdateSmokeSensorStateCommand(
            resource.Id,
            resource.State);
    }
}