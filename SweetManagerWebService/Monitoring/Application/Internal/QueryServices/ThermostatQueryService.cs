using SweetManagerWebService.Monitoring.Domain.Model.Aggregates;
using SweetManagerWebService.Monitoring.Domain.Model.Queries;
using SweetManagerWebService.Monitoring.Domain.Repositories;
using SweetManagerWebService.Monitoring.Domain.Services.Thermostat;

namespace SweetManagerWebService.Monitoring.Application.Internal.QueryServices;

public class ThermostatQueryService : IThermostatQueryServices
{
    private readonly IThermostatRepository _thermostatRepositoy;

    public ThermostatQueryService(IThermostatRepository thermostatRepositoy)
    {
        _thermostatRepositoy = thermostatRepositoy;
    }

    public async Task<Thermostat?> Handle(GetThermostatByIdQuery query)
    {
        return await _thermostatRepositoy.FindByIdAsync(query.id);
    }

    public async Task<IEnumerable<Thermostat>> Handle(GetThermostatByRoomIdQuery query)
    {
        
        return await _thermostatRepositoy.FindByRoomIdAsync(query.roomId);
    }

    public async Task<IEnumerable<Thermostat>> Handle(GetAllThermostatsByHotelIdQuery query)
    {
        return await _thermostatRepositoy.FindAllThermostats(query.HotelId);
    }
}