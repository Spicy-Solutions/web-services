using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Repositories.Users;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.IAM.Infrastructure.Persistence.EFC.Repositories.Users
{
    public class AdminRepository(SweetManagerContext context) : BaseRepository<Admin>(context), IAdminRepository
    {
        public async Task<bool> ExecuteUpdateAdminHotelIdAsync(int id, int hotelId)
         => await Context.Set<Admin>().Where(a => a.Id.Equals(id))
            .ExecuteUpdateAsync(ad => ad.SetProperty(a => a.HotelId, hotelId)) > 0;

        public async Task<dynamic?> FindAllByFiltersAsync(string? email, string? phone, string? state)
        {
            var query = Context.Admins.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(email))
                return await query.Where(a => a.Email!.Equals(email)).FirstOrDefaultAsync();

            if (!string.IsNullOrWhiteSpace(phone))
                query = query.Where(a => a.Phone!.Equals(phone));

            if (!string.IsNullOrWhiteSpace(state))
                query = query.Where(a => a.State!.Equals(state));

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Admin>> FindAllByHotelIdAsync(int hotelId)
          => await Context.Set<Admin>().Where(a => a.HotelId.Equals(hotelId)).ToListAsync();

        public async Task<int?> FindHotelIdByIdAsync(int id)
        {
            var result = await Context.Set<Admin>().Where(a => a.Id.Equals(id)).FirstOrDefaultAsync();

            return result?.HotelId;
        }
    }
}
