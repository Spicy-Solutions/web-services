using SweetManagerWebService.Monitoring.Domain.Model.Commands.TypeRoom;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.TypeRoom;

namespace SweetManagerWebService.Monitoring.Interfaces.REST.Transform.TypeRoom;

public class CreateTypeRoomCommandFromResourceAssembler
{
    public static CreateTypeRoomCommand CreateTypeRoomCommandFromResource(
        CreateTypeRoomResource resource)
    {
        return new CreateTypeRoomCommand(
            resource.Description,
            resource.Price);
    }
}