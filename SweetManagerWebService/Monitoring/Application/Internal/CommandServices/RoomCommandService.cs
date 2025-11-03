using SweetManagerWebService.Monitoring.Domain.Model.Aggregates;
using SweetManagerWebService.Monitoring.Domain.Model.Commands.Rooms;
using SweetManagerWebService.Monitoring.Domain.Repositories;
using SweetManagerWebService.Monitoring.Domain.Services.Room;
using SweetManagerWebService.Shared.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace SweetManagerWebService.Monitoring.Application.Internal.CommandServices;

public class RoomCommandService(IRoomRepository roomRepository, IUnitOfWork unitOfWork, SweetManagerContext context): IRoomCommandService
{

    public async Task<bool> Handle(CreateRoomCommand command)
    {
        if (command.TypeRoomId is null)
            throw new ArgumentException("TypeRoomId is required.");
        if (command.HotelId is null) 
            throw new ArgumentException("HotelId is required.");
        if (string.IsNullOrWhiteSpace(command.State))
            throw new ArgumentException("State is required.");

        var room = new Room(command);
        await roomRepository.AddAsync(room);
        await unitOfWork.CommitAsync();

        return true;
    }

    
    public async Task<bool> Handle(UpdateRoomStateCommand command)
    {
        try
        {
            await roomRepository.UpdateRoomStateAsync(command.Id, command.State);
            return true; 
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<bool> Handle(BulkRoomsCommand command)
    {
        var rooms = new List<Room>();

        int count = command.Count;

        for (int i = 0; i < count; i++)
        {
            var cmd = new CreateRoomCommand(command.RoomTypeId, command.HotelId, "ACTIVE");
            rooms.Add(new Room(cmd)); // No uses constructor que setea Id
        }

        await context.Rooms.AddRangeAsync(rooms);
        await unitOfWork.CommitAsync();

        return true;
    }
}