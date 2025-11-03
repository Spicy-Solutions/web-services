using SweetManagerWebService.IAM.Domain.Model.Commands.Preferences;
using SweetManagerWebService.IAM.Interfaces.REST.Resources.Preferences;

namespace SweetManagerWebService.IAM.Interfaces.REST.Transform.Preferences
{
    public static class UpdateGuestPreferenceCommandFromResourceAssembler
    {
        public static UpdateGuestPreferenceCommand ToCommandFromResource(UpdateGuestPreferenceResource resource, int id)
        {
            return new UpdateGuestPreferenceCommand(id,resource.GuestId, resource.Temperature);
        }
    }
}