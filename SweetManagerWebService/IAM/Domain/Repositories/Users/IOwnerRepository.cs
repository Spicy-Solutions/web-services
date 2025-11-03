using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Domain.Repositories.Users
{
    public interface IOwnerRepository : IBaseRepository<Owner>
    {
        Task<dynamic?> FindAllByFiltersAsync(string? email, string? phone, string? state);

        Task<Owner?> FindByHotelIdAsync(int hotelId);

        Task<int?> FindHotelIdByIdAsync(int id);
    }
}