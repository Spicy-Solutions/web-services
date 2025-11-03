using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;
using SweetManagerWebService.IAM.Domain.Model.Queries.Preferences;
using SweetManagerWebService.IAM.Domain.Repositories.Preferences;
using SweetManagerWebService.IAM.Domain.Services.QueryServices.Preferences;

namespace SweetManagerWebService.IAM.Application.Internal.QueryServices.Preferences
{
    public class GuestPreferenceQueryService(IGuestPreferenceRepository guestPreferenceRepository) : IGuestPreferenceQueryService
    {
        public async Task<GuestPreference?> Handle(GetGuestPreferenceByGuestIdQuery query)
         => await guestPreferenceRepository.FindByGuestId(query.GuestId);

        public async Task<GuestPreference?> Handle(GetGuestPreferenceByIdQuery query)
         => await guestPreferenceRepository.FindByIdAsync(query.Id);

    }
}
