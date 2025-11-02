using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerIotWebService.Inventory.Infrastructure.Persistence.Repositories;

public class RfidCardRepository(SweetManagerContext context) : BaseRepository<RfidCard>(context), IRfidCardRepository
{
    public async Task<IEnumerable<RfidCard>> FindByHotelIdAsync(int hotelId)
    {
        var rfids = await context.RfidCards
            .Where(rfid => rfid.Room != null && rfid.Room.HotelId == hotelId)
            .ToListAsync();

        return rfids;
    }
}