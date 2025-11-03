using SweetManagerWebService.IAM.Application.Internal.OutboundServices;
using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Commands.Authentication;
using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Exceptions;
using SweetManagerWebService.IAM.Domain.Repositories.Credentials;
using SweetManagerWebService.IAM.Domain.Repositories.Users;
using SweetManagerWebService.IAM.Domain.Services.CommandServices.Users;
using SweetManagerWebService.IAM.Infrastructure.Persistence.EFC.Repositories.Users;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Application.Internal.CommandServices.Users
{
    public class OwnerCommandService(IOwnerRepository ownerRepository,
        IHashingService hashingService, IUnitOfWork unitOfWork,
        IOwnerCredentialRepository ownerCredentialRepository, ITokenService tokenService) : IOwnerCommandService
    {
        public async Task<Owner?> Handle(SignUpUserCommand command)
        {
            try
            {
                if (await ownerRepository.FindAllByFiltersAsync(command.Email, null, null) is not null)
                    throw new EmailAlreadyExistException();

                // Add Admin

                var entity = new Owner(command.Id, command.Name, command.Surname, command.Phone,
                    command.Email, "ACTIVE", 1, command.PhotoURL);

                await ownerRepository.AddAsync(entity);

                await unitOfWork.CommitAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while creating the user: {ex.Message}");
            }
        }

        public async Task<Owner?> Handle(UpdateUserCommand command)
        {
            try
            {
                var owner = await ownerRepository.FindByIdAsync(command.Id) ?? throw new Exception($"There's no owner with the given id: {command.Id}");

                owner.Update(command);

                await unitOfWork.CommitAsync();

                return owner;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while updating the user: {ex.Message}");
            }
        }

        public async Task<dynamic?> Handle(SignInUserCommand command)
        {
            try
            {
                var user = await ownerRepository.FindAllByFiltersAsync(command.Email, null, null);

                if (user is null)
                    throw new EmailDoesntExistException();

                OwnerCredential userCredential = await ownerCredentialRepository.FindByIdAsync(user.Id);

                if (!hashingService.VerifyHash(command.Password, userCredential!.Code[..24], userCredential!.Code[24..]))
                    throw new InvalidPasswordException();

                var hotel = await ownerRepository.FindHotelIdByIdAsync(user.Id);

                hotel ??= 0;

                var token = tokenService.GenerateToken(new
                {
                    Id = user.Id,
                    PasswordHash = userCredential.Code,
                    Role = "ROLE_OWNER",
                    Hotel = hotel
                });

                return new
                {
                    User = user,
                    Token = token
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
