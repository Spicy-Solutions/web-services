using SweetManagerWebService.Monitoring.Domain.Model.Commands.TypeRoom;

namespace SweetManagerWebService.Monitoring.Domain.Services.TypeRoom;

public interface ITypeRoomCommandService
{
    Task<Domain.Model.Entities.TypeRoom?> Handle(CreateTypeRoomCommand command);
}