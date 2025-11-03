namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.Rooms;

public record BulkRoomsCommand(int Count, int RoomTypeId, int HotelId);