using SweetManagerWebService.Monitoring.Domain.Model.Commands.TypeRoom;
using SweetManagerWebService.Monitoring.Domain.Model.Entities;
using SweetManagerWebService.Monitoring.Domain.Repositories;
using SweetManagerWebService.Monitoring.Domain.Services.TypeRoom;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Monitoring.Application.Internal.CommandServices;

public class TypeRoomCommandServices(ITypeRoomRepository typeRoomRepository, IUnitOfWork unitOfWork) :ITypeRoomCommandService
{
    IUnitOfWork _unitOfWork = unitOfWork;
    ITypeRoomRepository _roomRepository = typeRoomRepository;
    
    public async Task<TypeRoom?> Handle(CreateTypeRoomCommand command)
    {
        if (string.IsNullOrWhiteSpace(command.Description))
            throw new ArgumentException("Description is required.");
        if (command.Price <= 0)
            throw new ArgumentException("Price is required.");


        var typeRoom = new TypeRoom(command);
        await _roomRepository.AddAsync(typeRoom);
        await _unitOfWork.CommitAsync();

        return typeRoom;
    }
}