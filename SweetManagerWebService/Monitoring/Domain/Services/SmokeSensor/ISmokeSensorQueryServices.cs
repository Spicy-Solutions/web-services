using SweetManagerWebService.Monitoring.Domain.Model.Queries;

namespace SweetManagerWebService.Monitoring.Domain.Services.SmokeSensor;

public interface ISmokeSensorQueryServices
{
    Task<IEnumerable<Model.Aggregates.SmokeSensor>> Handle(GetAllSmokeSensorsByHotelIdQuery query);

    Task<Model.Aggregates.SmokeSensor?> Handle(GetSmokeSensorByIdQuery query);

    Task<IEnumerable<Model.Aggregates.SmokeSensor>> Handle(GetSmokeSensorByRoomIdQuery query);

}