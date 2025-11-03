using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;
using SweetManagerWebService.IAM.Domain.Repositories.Preferences;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.IAM.Infrastructure.Persistence.EFC.Repositories.Preferences
{
    public class GuestPreferenceRepository(SweetManagerContext context) : BaseRepository<GuestPreference>(context),
        IGuestPreferenceRepository
    {
        public async Task<GuestPreference?> FindByGuestId(int guestId)
        => await Context.Set<GuestPreference>().Where(g => g.GuestId.Equals(guestId)).FirstOrDefaultAsync();

    }
}