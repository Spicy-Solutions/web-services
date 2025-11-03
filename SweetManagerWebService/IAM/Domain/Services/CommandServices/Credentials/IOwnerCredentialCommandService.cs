using SweetManagerWebService.IAM.Domain.Model.Commands.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;

namespace SweetManagerWebService.IAM.Domain.Services.CommandServices.Credentials
{
    public interface IOwnerCredentialCommandService
    {
        Task<OwnerCredential?> Handle(CreateUserCredentialCommand command);

        Task<OwnerCredential?> Handle(UpdateUserCredentialCommand command);
    }
}