using SweetManagerWebService.Monitoring.Domain.Model.Queries;

namespace SweetManagerWebService.Monitoring.Domain.Services.Thermostat;

public interface IThermostatQueryServices
{
    Task<IEnumerable<Model.Aggregates.Thermostat>> Handle(GetAllThermostatsByHotelIdQuery query);

    Task<Model.Aggregates.Thermostat?> Handle(GetThermostatByIdQuery query);

    Task<IEnumerable<Model.Aggregates.Thermostat>> Handle(GetThermostatByRoomIdQuery query);

}