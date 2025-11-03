namespace SweetManagerWebService.Communication.Interfaces.REST.Resources;

public record CreateNotificationResource(string Title, string Content, string SenderType, int SenderId, int ReceiverId, int HotelId);