using SweetManagerWebService.IAM.Domain.Model.Commands.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;

namespace SweetManagerWebService.IAM.Domain.Services.CommandServices.Credentials
{
    public interface IGuestCredentialCommandService
    {
        Task<GuestCredential?> Handle(CreateUserCredentialCommand command);

        Task<GuestCredential?> Handle(UpdateUserCredentialCommand command);
    }
}