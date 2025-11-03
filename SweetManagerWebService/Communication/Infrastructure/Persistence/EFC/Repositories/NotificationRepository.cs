using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.Communication.Domain.Model.Aggregates;
using SweetManagerWebService.Communication.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.Communication.Infrastructure.Persistence.EFC.Repositories;

public class NotificationRepository(SweetManagerContext context) : BaseRepository<Notification>(context), INotificationRepository
{
    public async Task<IEnumerable<Notification>> GetNotificationsByHotelIdAsync(int hotelId)
    {
        return await Context.Set<Notification>()
            .Where(s => s.HotelId == hotelId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Notification>> GetNotificationsBySenderIdAsync(int senderId)
    {
        return await Context.Set<Notification>().Where(s => s.SenderId == senderId ).ToListAsync();
    }

    public async Task<IEnumerable<Notification>> GetNotificationsByReceiverIdAsync(int receiverId)
    {
        return await Context.Set<Notification>().Where(s => s.ReceiverId == receiverId).ToListAsync();
    }

    public async Task<IEnumerable<Notification>> GetNotificationsBySenderAndReceiverIdAsync(int senderId, int receiverId)
    {
        return await Context.Set<Notification>().Where(s => s.SenderId == senderId && s.ReceiverId == receiverId).ToListAsync();
    }
}