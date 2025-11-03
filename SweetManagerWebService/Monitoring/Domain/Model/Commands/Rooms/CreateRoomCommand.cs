namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.Rooms;

public record CreateRoomCommand(int? TypeRoomId,
    int? HotelId,
    string? State);