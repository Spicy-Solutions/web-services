using SweetManagerWebService.Monitoring.Domain.Model.Commands.Rooms;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Room;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Room;

public class CreateRoomCommandFromResourceAssembler
{
    public static CreateRoomCommand ToCommandFromResource(CreateRoomResource resource)
    {
        return new CreateRoomCommand(resource.TypeRoomId, resource.HotelId, resource.State);
    }
}