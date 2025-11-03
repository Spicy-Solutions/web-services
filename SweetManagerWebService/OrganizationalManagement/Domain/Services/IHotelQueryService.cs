using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Services;

public interface IHotelQueryService
{
    Task<Hotel?> Handle(GetHotelByIdQuery query);
    Task<IEnumerable<Hotel>> Handle(GetAllHotelsQuery query);
    Task<IEnumerable<Hotel>> Handle(GetHotelByOwnerId query);
}