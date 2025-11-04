using SweetManagerWebService.Monitoring.Domain.Model.Queries;

namespace SweetManagerWebService.Monitoring.Domain.Services.Room;

public interface IRoomQueryService
{
    Task<IEnumerable<Model.Aggregates.Room>> Handle(GetAllRoomsQuery query);

    Task<Model.Aggregates.Room?> Handle(GetRoomsByIdQuery query);

    Task<IEnumerable<Model.Aggregates.Room>> Handle(GetRoomsByStateQuery query);

    Task<IEnumerable<Model.Aggregates.Room>> Handle(GetRoomsByTypeRoomIdQuery query);
}