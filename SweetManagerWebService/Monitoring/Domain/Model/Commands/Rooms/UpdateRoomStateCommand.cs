namespace SweetManagerWebService.Monitoring.Domain.Model.Commands.Rooms;

public record UpdateRoomStateCommand(int Id, string State);