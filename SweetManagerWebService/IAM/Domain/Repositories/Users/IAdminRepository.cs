using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Domain.Repositories.Users
{
    public interface IAdminRepository : IBaseRepository<Admin>
    {
        Task<dynamic?> FindAllByFiltersAsync(string? email, string? phone, string? state);

        Task<IEnumerable<Admin>> FindAllByHotelIdAsync(int hotelId);

        Task<int?> FindHotelIdByIdAsync(int id);

        Task<bool> ExecuteUpdateAdminHotelIdAsync(int id, int hotelId);
    }
}