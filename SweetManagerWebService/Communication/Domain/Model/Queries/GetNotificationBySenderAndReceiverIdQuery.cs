namespace SweetManagerWebService.Communication.Domain.Model.Queries;

public record GetNotificationBySenderAndReceiverIdQuery(int SenderId, int ReceiverId);