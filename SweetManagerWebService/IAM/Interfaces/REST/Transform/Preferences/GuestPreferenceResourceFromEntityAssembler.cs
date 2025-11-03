using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;
using SweetManagerWebService.IAM.Interfaces.REST.Resources.Preferences;

namespace SweetManagerWebService.IAM.Interfaces.REST.Transform.Preferences
{
    public static class GuestPreferenceResourceFromEntityAssembler
    {
        public static GuestPreferenceResource ToResourceFromEntity(GuestPreference entity)
        {
            return new GuestPreferenceResource(entity.Id,entity.GuestId, entity.Temperature);
        }
    }
}