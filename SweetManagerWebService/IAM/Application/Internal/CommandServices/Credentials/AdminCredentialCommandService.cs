using SweetManagerWebService.IAM.Application.Internal.OutboundServices;
using SweetManagerWebService.IAM.Domain.Model.Commands.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Repositories.Credentials;
using SweetManagerWebService.IAM.Domain.Services.CommandServices.Credentials;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Application.Internal.CommandServices.Credentials
{
    public class AdminCredentialCommandService(IAdminCredentialRepository adminCredentialRepository, 
        IHashingService hashingService, IUnitOfWork unitOfWork) : IAdminCredentialCommandService
    {
        public async Task<AdminCredential?> Handle(CreateUserCredentialCommand command)
        {
            try
            {
                var salt = hashingService.CreateSalt();

                var code = hashingService.HashCode(command.Code, salt);

                await adminCredentialRepository.AddAsync(new AdminCredential(command.Id, string.Concat(salt, code)));

                await unitOfWork.CommitAsync();

                return new AdminCredential(command.Id, string.Concat(salt, code));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<AdminCredential?> Handle(UpdateUserCredentialCommand command)
        {
            try
            {
                var salt = hashingService.CreateSalt();

                var code = hashingService.HashCode(command.Code, salt);

                adminCredentialRepository.Update(new AdminCredential(command.Id, string.Concat(salt, code)));

                await unitOfWork.CommitAsync();

                return new AdminCredential(command.Id, string.Concat(salt, code));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
