using SweetManagerWebService.IAM.Domain.Model.Commands.Preferences;
using SweetManagerWebService.IAM.Interfaces.REST.Resources.Preferences;

namespace SweetManagerWebService.IAM.Interfaces.REST.Transform.Preferences
{
    public static class CreateGuestPreferenceCommandFromResourceAssembler
    {
        public static CreateGuestPreferenceCommand ToCommandFromResource(CreateGuestPreferenceResource resource)
        {
            return new CreateGuestPreferenceCommand(resource.GuestId, resource.Temperature);
        }
    }
}