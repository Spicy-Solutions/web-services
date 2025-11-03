using SweetManagerWebService.Monitoring.Domain.Model.Aggregates;
using SweetManagerWebService.Monitoring.Domain.Model.Commands.Thermostat;
using SweetManagerWebService.Monitoring.Domain.Repositories;
using SweetManagerWebService.Monitoring.Domain.Services.Thermostat;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Monitoring.Application.Internal.CommandServices;

public class ThermostatCommandService(IThermostatRepository thermostatRepositoy, IUnitOfWork unitOfWork) : IThermostatCommandService
{
    
    IThermostatRepository _thermostatRepositoy = thermostatRepositoy;
    IUnitOfWork _unitOfWork = unitOfWork;
    
    public async Task<bool> Handle(CreateThermostatCommand command)
    {
        if (command.RoomId is null)
            throw new ArgumentException("RoomId is required.");
        if (command.Temperature is null)
            throw new ArgumentException("Temperature is required.");
        if (command.IpAddress is null)
            throw new ArgumentException("IpAddress is required.");
        if (command.State is null)
            throw new ArgumentException("State is required.");
       

        var thermostat = new Thermostat(command);
        await _thermostatRepositoy.AddAsync(thermostat);
        await _unitOfWork.CommitAsync();

        return true;
    }
    
    public async Task<bool> Handle(UpdateThermostatStateCommand command)
    {
        if (command.State is null)
            throw new ArgumentException("State is required.");
        
        try
        {
            await _thermostatRepositoy.UpdateThermostatState(command.Id, command.State);
            return true; 
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    public async Task<bool> Handle(UpdateThermostatTemperatureCommand command)
    {
        if (command.Temperature is null)
            throw new ArgumentException("Temperature is required.");
        try
        {
            await _thermostatRepositoy.UpdateThermostatTemperature(command.Id, command.Temperature);
            return true; 
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    public async Task<bool> Handle(UpdateThermostatCommand command)
    {
        if (command.RoomId is null)
            throw new ArgumentException("RoomId is required.");
        if (command.Temperature is null)
            throw new ArgumentException("Temperature is required.");
        if (command.IpAddress is null)
            throw new ArgumentException("IpAddress is required.");
        if (command.State is null)
            throw new ArgumentException("State is required.");

        var thermostat = new Thermostat(command);
        await _thermostatRepositoy.UpdateThermostat(thermostat.Id, thermostat.RoomId, thermostat.IpAddress, thermostat.MacAddress, thermostat.Temperature, thermostat.State, thermostat.LastUpdate);
        await _unitOfWork.CommitAsync();

        return true;
    }
}