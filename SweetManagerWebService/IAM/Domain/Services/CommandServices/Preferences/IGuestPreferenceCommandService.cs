using SweetManagerWebService.IAM.Domain.Model.Commands.Preferences;
using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;

namespace SweetManagerWebService.IAM.Domain.Services.CommandServices.Preferences
{
    public interface IGuestPreferenceCommandService
    {
        Task<GuestPreference?> Handle(CreateGuestPreferenceCommand command);

        Task<GuestPreference?> Handle(UpdateGuestPreferenceCommand command);
    }
}