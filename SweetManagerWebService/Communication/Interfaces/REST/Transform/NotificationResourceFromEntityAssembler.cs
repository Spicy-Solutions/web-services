using SweetManagerWebService.Communication.Domain.Model.Aggregates;
using SweetManagerWebService.Communication.Interfaces.REST.Resources;

namespace SweetManagerWebService.Communication.Interfaces.REST.Transform;

public static class NotificationResourceFromEntityAssembler
{
    public static NotificationResource ToResourceFromEntity(Notification entity) 
    {
        return new NotificationResource(entity.Id, entity.Title, entity.Content, entity.SenderType, entity.SenderId,
            entity.ReceiverId, entity.HotelId);
    }
}