using SweetManagerWebService.IAM.Application.Internal.OutboundServices;
using SweetManagerWebService.IAM.Domain.Model.Commands.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Repositories.Credentials;
using SweetManagerWebService.IAM.Domain.Services.CommandServices.Credentials;
using SweetManagerWebService.IAM.Infrastructure.Persistence.EFC.Repositories.Credentials;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Application.Internal.CommandServices.Credentials
{
    public class OwnerCredentialCommandService(IOwnerCredentialRepository ownerCredentialRepository,
        IHashingService hashingService, IUnitOfWork unitOfWork) : IOwnerCredentialCommandService
    {
        public async Task<OwnerCredential?> Handle(CreateUserCredentialCommand command)
        {
            try
            {
                var salt = hashingService.CreateSalt();
                var code = hashingService.HashCode(command.Code, salt);

                await ownerCredentialRepository.AddAsync(new OwnerCredential(command.Id, string.Concat(salt, code)));

                await unitOfWork.CommitAsync();

                return new OwnerCredential(command.Id, string.Concat(salt, code));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<OwnerCredential?> Handle(UpdateUserCredentialCommand command)
        {
            try
            {
                var salt = hashingService.CreateSalt();
                var code = hashingService.HashCode(command.Code, salt);

                await ownerCredentialRepository.AddAsync(new OwnerCredential(command.Id, string.Concat(salt, code)));

                await unitOfWork.CommitAsync();

                return new OwnerCredential(command.Id, string.Concat(salt, code));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
