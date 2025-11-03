using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.OrganizationalManagement.Domain.Services;

namespace SweetManagerWebService.OrganizationalManagement.Application.Internal.QueryServices;

public class HotelQueryService(IHotelRepository hotelRepository) : IHotelQueryService
{
    public async Task<Hotel?> Handle(GetHotelByIdQuery query)
    {
        return await hotelRepository.FindByIdAsync(query.HotelId);
    }
    
    public async Task<IEnumerable<Hotel>> Handle(GetAllHotelsQuery query)
    {
        return await hotelRepository.GetAllHotelsAsync();
    }
    
    public async Task<IEnumerable<Hotel>> Handle(GetHotelByOwnerId query)
    {
        return await hotelRepository.FindByOwnerIdAsync(query.OwnerId);
    }
}