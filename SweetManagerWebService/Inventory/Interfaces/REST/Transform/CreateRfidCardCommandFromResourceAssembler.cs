using SweetManagerWebService.Inventory.Domain.Model.Commands;
using SweetManagerWebService.Inventory.Interfaces.REST.Resources;

namespace SweetManagerWebService.Inventory.Interfaces.REST.Transform;

public static class CreateRfidCardCommandFromResourceAssembler
{
    public static CreateRfidCardCommand ToCommandFromResource(CreateRfidCardResource resource)
    {
        return new CreateRfidCardCommand(
            resource.RoomId,
            resource.ApiKey,
            resource.UId);
    }
}