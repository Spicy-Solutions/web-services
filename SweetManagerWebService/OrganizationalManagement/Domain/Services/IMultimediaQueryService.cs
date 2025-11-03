using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Services;

public interface IMultimediaQueryService
{
    Task<IEnumerable<Multimedia>> Handle(GetAllDetailMultimediaByHotelIdQuery query);

    Task<Multimedia?> Handle(GetMainMultimediaByHotelIdQuery query);

    Task<Multimedia?> Handle(GetLogoMultimediaByHotelIdQuery query);
}