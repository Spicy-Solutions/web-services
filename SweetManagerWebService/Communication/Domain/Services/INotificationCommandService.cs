using SweetManagerWebService.Communication.Domain.Model.Aggregates;
using SweetManagerWebService.Communication.Domain.Model.Commands;

namespace SweetManagerWebService.Communication.Domain.Services;

public interface INotificationCommandService
{
    Task<Notification?> Handle(CreateNotificationCommand command);

    Task<bool> Handle(CreateAdminRequestToOrganizationCommand command);

}