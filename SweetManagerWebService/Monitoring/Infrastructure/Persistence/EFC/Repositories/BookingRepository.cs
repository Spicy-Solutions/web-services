using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Monitoring.Domain.Model.Aggregates;
using SweetManagerWebService.Monitoring.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.Monitoring.Infrastructure.Persistence.EFC.Repositories;

public class BookingRepository(SweetManagerContext context): BaseRepository<Booking>(context), IBookingRepository
{
    public async Task<IEnumerable<Booking>> FindAllByHotelIdAsync(int? hotelId)
    {
        var query = from b in Context.Set<Booking>()
            join ro in Context.Set<Room>() on b.RoomId equals ro.Id
            where ro.HotelId == hotelId
            select b;

        return await query.ToListAsync();
    }


    public async Task<IEnumerable<Booking>> FindByCustomerIdAsync(int customerId)
    {
        var query = from b in Context.Set<Booking>()
            join pref in Context.Set<GuestPreference>() on b.PreferenceId equals pref.Id
            where pref.GuestId == customerId
            select b;

        return await query.ToListAsync();
    }


    public async Task<IEnumerable<Booking>> FindByHotelIdAndStateAsync(int hotelId, string state)
    {
        var query = from b in Context.Set<Booking>()
            join ro in Context.Set<Room>() on b.RoomId equals ro.Id
            where ro.HotelId == hotelId && b.State == state
            select b;

        return await query.ToListAsync();
    }


    public async Task<bool> UpdateBookingEndDateAsync(int id, DateTime endDate)
    {
        var booking = await Context.Set<Booking>().FindAsync(id);
        if (booking == null)
            return false;
        booking.FinalDate = endDate;
        await Context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateBookingStateAsync(int id, string state)
    {
        var booking = await Context.Set<Booking>().FindAsync(id);
        if (booking == null)
            return false;
        booking.State = state;
        await Context.SaveChangesAsync();
        return true;
    }
}