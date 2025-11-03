using SweetManagerWebService.Communication.Domain.Model.Commands;
using SweetManagerWebService.Communication.Interfaces.REST.Resources;

namespace SweetManagerWebService.Communication.Interfaces.REST.Transform;

public static class CreateNotificationCommandFromResourceAssembler
{
    public static CreateNotificationCommand ToCommandFromResource(CreateNotificationResource resource)
    {
        return new CreateNotificationCommand(
            resource.Title, 
            resource.Content, 
            resource.SenderType, 
            resource.SenderId, 
            resource.ReceiverId,
            resource.HotelId
            );
    }
}