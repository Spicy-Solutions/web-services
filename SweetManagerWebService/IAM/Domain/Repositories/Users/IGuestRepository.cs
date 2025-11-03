using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Domain.Repositories.Users
{
    public interface IGuestRepository : IBaseRepository<Guest>
    {
        Task<dynamic?> FindAllByFiltersAsync(string? email, string? phone, string? state);

        Task<IEnumerable<Guest>> FindAllByHotelIdAsync(int hotelId);

        Task<int?> FindHotelIdByIdAsync(int id);
    }
}