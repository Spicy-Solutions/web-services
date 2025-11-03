using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Domain.Repositories.Preferences
{
    public interface IGuestPreferenceRepository : IBaseRepository<GuestPreference>
    {
        Task<GuestPreference?> FindByGuestId(int guestId); 

    }
}