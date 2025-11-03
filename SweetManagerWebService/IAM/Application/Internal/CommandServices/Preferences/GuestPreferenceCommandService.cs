using SweetManagerWebService.IAM.Domain.Model.Commands.Preferences;
using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;
using SweetManagerWebService.IAM.Domain.Repositories.Preferences;
using SweetManagerWebService.IAM.Domain.Services.CommandServices.Preferences;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Application.Internal.CommandServices.Preferences
{
    public class GuestPreferenceCommandService(IGuestPreferenceRepository guestPreferenceRepository,
        IUnitOfWork unitOfWork) : IGuestPreferenceCommandService
    {
        public async Task<GuestPreference?> Handle(CreateGuestPreferenceCommand command)
        {
            try
            {
                var entity = new GuestPreference(command);

                await guestPreferenceRepository.AddAsync(entity);

                await unitOfWork.CommitAsync();

                return entity;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public async Task<GuestPreference?> Handle(UpdateGuestPreferenceCommand command)
        {
            try
            {
                var entity = await guestPreferenceRepository.FindByIdAsync(command.Id) ?? throw new Exception("The guest preference with the given id, doesn't exists.");
                entity.Update(command);

                guestPreferenceRepository.Update(entity);

                await unitOfWork.CommitAsync();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
