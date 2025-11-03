using SweetManagerWebService.Monitoring.Domain.Model.Commands.Rooms;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Room;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Room;

public static class BulkRoomsCommandFromResourceAssembler
{
    public static BulkRoomsCommand ToCommandFromResource(BulkRoomsResource resource)
    {
        return new BulkRoomsCommand(resource.Count,resource.TypeRoomId, resource.HotelId);
    }
}