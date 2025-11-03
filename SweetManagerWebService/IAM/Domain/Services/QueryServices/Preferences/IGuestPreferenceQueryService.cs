using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;
using SweetManagerWebService.IAM.Domain.Model.Queries.Preferences;

namespace SweetManagerWebService.IAM.Domain.Services.QueryServices.Preferences
{
    public interface IGuestPreferenceQueryService
    {
        Task<GuestPreference?> Handle(GetGuestPreferenceByGuestIdQuery query);

        Task<GuestPreference?> Handle(GetGuestPreferenceByIdQuery query);
    }
}