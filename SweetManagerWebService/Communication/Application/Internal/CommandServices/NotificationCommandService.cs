using SweetManagerWebService.Communication.Application.Internal.OutboundServices;
using SweetManagerWebService.Communication.Application.Internal.OutboundServices.ACL;
using SweetManagerWebService.Communication.Domain.Model.Aggregates;
using SweetManagerWebService.Communication.Domain.Model.Commands;
using SweetManagerWebService.Communication.Domain.Model.Exceptions;
using SweetManagerWebService.Communication.Domain.Repositories;
using SweetManagerWebService.Communication.Domain.Services;
using SweetManagerWebService.Shared.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Miscellaneous.Templates;

namespace SweetManagerWebService.Communication.Application.Internal.CommandServices;

public class NotificationCommandService(INotificationRepository notificationRepository, IUnitOfWork unitOfWork,
    IMailService mailService, ExternalIAMService externalIAMService, 
    ExternalOrganizationManagementService externalOrganizationManagementService) : INotificationCommandService
{
    public async Task<Notification?> Handle(CreateNotificationCommand command)
    {
        var notification = new Notification(command);
        try
        {
            await notificationRepository.AddAsync(notification);
            await unitOfWork.CommitAsync();
            return notification;
        } catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the notification: {e.Message}");
            return null;
        }
    }

    public async Task<bool> Handle(CreateAdminRequestToOrganizationCommand command)
    {
        var recoveredUser = await externalIAMService.FetchAdminById(command.AdminId) ?? throw new AnyUserExistWithTheGivenIdException();

        var ownerId = await externalOrganizationManagementService.FetchOwnerIdByHotelId(command.HotelId) ?? throw new ExternalServicesProcessFailedException();

        var ownerContact = await externalIAMService.FetchOwnerNameAndEmailById(ownerId.Id);

        string body = Mail.GenerateAdminRequestToOrganization(recoveredUser.Name, recoveredUser.FullName, recoveredUser.Email, recoveredUser.Phone, command.AdditionalMessage, ownerContact?.Name!, command.HotelId);

        string subject = $"SOLICITUD DE TRABAJO - {recoveredUser.FullName}";
        
        mailService.SendEmail(subject, body, ownerContact?.Email!);

        return true;
    }
}