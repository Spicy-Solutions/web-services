using SweetManagerWebService.Monitoring.Domain.Model.Commands.Rooms;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Room;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Room;

public class UpdateRoomStateCommandFromResource
{
    public static UpdateRoomStateCommand ToCommandFromResource(UpdateRoomStateResource resource) =>
        new(resource.Id, resource.State);
}