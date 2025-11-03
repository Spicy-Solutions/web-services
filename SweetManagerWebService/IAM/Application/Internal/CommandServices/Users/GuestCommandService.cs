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
    public class GuestCommandService(IGuestRepository guestRepository,
        IHashingService hashingService, IUnitOfWork unitOfWork,
        IGuestCredentialRepository guestCredentialRepository, ITokenService tokenService) : IGuestCommandService
    {
        public async Task<Guest?> Handle(SignUpUserCommand command)
        {
            try
            {
                if (await guestRepository.FindAllByFiltersAsync(command.Email, null, null) is not null)
                    throw new EmailAlreadyExistException();

                // Add Admin

                var entity = new Guest(command.Id, command.Name, command.Surname, command.Phone,
                    command.Email, "ACTIVE", 3, command.PhotoURL);

                await guestRepository.AddAsync(entity);

                await unitOfWork.CommitAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while creating the user: {ex.Message}");
            }
        }

        public async Task<Guest?> Handle(UpdateUserCommand command)
        {
            try
            {
                var guest = await guestRepository.FindByIdAsync(command.Id) ?? throw new Exception($"There's no guest with the given id: {command.Id}");

                guest.Update(command);

                await unitOfWork.CommitAsync();

                return guest;
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
                var user = await guestRepository.FindAllByFiltersAsync(command.Email, null, null);

                if (user is null)
                    throw new EmailDoesntExistException();

                GuestCredential userCredential = await guestCredentialRepository.FindByIdAsync(user.Id);

                if (!hashingService.VerifyHash(command.Password, userCredential!.Code[..24], userCredential!.Code[24..]))
                    throw new InvalidPasswordException();

                var hotel = await guestRepository.FindHotelIdByIdAsync(user.Id);

                hotel ??= 0;

                var token = tokenService.GenerateToken(new
                {
                    Id = user.Id,
                    PasswordHash = userCredential.Code,
                    Role = "ROLE_GUEST",
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
