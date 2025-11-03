using SweetManagerWebService.IAM.Domain.Model.Commands.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;

namespace SweetManagerWebService.IAM.Domain.Services.CommandServices.Credentials
{
    public interface IAdminCredentialCommandService
    {
        Task<AdminCredential?> Handle(CreateUserCredentialCommand command);

        Task<AdminCredential?> Handle(UpdateUserCredentialCommand command);
    }
}