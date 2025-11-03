using SweetManagerWebService.Monitoring.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Monitoring.Domain.Repositories;

public interface ISmokeSensorRepositoy : IBaseRepository<SmokeSensor>
{
    Task<IEnumerable<SmokeSensor>> FindByRoomIdAsync(int roomId);
    
    Task<IEnumerable<SmokeSensor>>  FindById(int id);
    
    Task<IEnumerable<SmokeSensor>>  FindAllSmokeSensors(int hotelId);
    
    Task<bool> UpdateSmokeSensorState(int id, string state);

    Task<bool> UpdateSmokeSensorAnalogicValue(int id, double? lastAnalogicValue);
    
    Task<bool> UpdateSmokeSensor(int id, int? roomId, string? ipAddress, string? macAddress,
        double? lastAnalogicValue, string? state, DateTime? lastAlertTime);
}