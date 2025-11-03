using SweetManagerWebService.IAM.Application.Internal.OutboundServices;
using SweetManagerWebService.IAM.Domain.Model.Commands.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Repositories.Credentials;
using SweetManagerWebService.IAM.Domain.Services.CommandServices.Credentials;
using SweetManagerWebService.IAM.Infrastructure.Persistence.EFC.Repositories.Credentials;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Application.Internal.CommandServices.Credentials
{
    public class GuestCredentialCommandService(IGuestCredentialRepository guestCredentialRepository,
        IHashingService hashingService, IUnitOfWork unitOfWork) : IGuestCredentialCommandService
    {
        public async Task<GuestCredential?> Handle(CreateUserCredentialCommand command)
        {
            try
            {
                var salt = hashingService.CreateSalt();
                var code = hashingService.HashCode(command.Code, salt);

                await guestCredentialRepository.AddAsync(new GuestCredential(command.Id, string.Concat(salt, code)));

                await unitOfWork.CommitAsync();

                return new GuestCredential(command.Id, string.Concat(salt, code));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<GuestCredential?> Handle(UpdateUserCredentialCommand command)
        {
            try
            {
                var salt = hashingService.CreateSalt();
                var code = hashingService.HashCode(command.Code, salt);

                await guestCredentialRepository.AddAsync(new GuestCredential(command.Id, string.Concat(salt, code)));

                await unitOfWork.CommitAsync();

                return new GuestCredential(command.Id, string.Concat(salt, code));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
