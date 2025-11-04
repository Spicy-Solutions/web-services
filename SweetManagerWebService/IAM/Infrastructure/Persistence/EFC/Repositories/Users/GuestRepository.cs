﻿using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Repositories.Users;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.IAM.Infrastructure.Persistence.EFC.Repositories.Users
{
    public class GuestRepository(SweetManagerContext context) : BaseRepository<Guest>(context), IGuestRepository
    {
        public async Task<dynamic?> FindAllByFiltersAsync(string? email, string? phone, string? state)
        {
            var query = Context.Guests.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(email))
                return await query.Where(a => a.Email!.Equals(email)).FirstOrDefaultAsync();

            if (!string.IsNullOrWhiteSpace(phone))
                query = query.Where(a => a.Phone!.Equals(phone));

            if (!string.IsNullOrWhiteSpace(state))
                query = query.Where(a => a.State!.Equals(state));

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Guest>> FindAllByHotelIdAsync(int hotelId)
        {
            // Since the Booking bounded context was removed, this method returns an empty list
            // TODO: Implement alternative logic if needed based on new requirements
            return await Task.FromResult(new List<Guest>());
        }

        public async Task<int?> FindHotelIdByIdAsync(int id)
        {
            // Since the Booking bounded context was removed, this method returns null
            // TODO: Implement alternative logic if needed based on new requirements
            return await Task.FromResult<int?>(null);
        }
    }
}