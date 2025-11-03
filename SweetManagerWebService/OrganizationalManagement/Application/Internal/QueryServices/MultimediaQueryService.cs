using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.OrganizationalManagement.Domain.Services;

namespace SweetManagerWebService.OrganizationalManagement.Application.Internal.QueryServices;

public class MultimediaQueryService(IMultimediaRepository multimediaRepository) : IMultimediaQueryService
{
    public async Task<IEnumerable<Multimedia>> Handle(GetAllDetailMultimediaByHotelIdQuery query)
        => await multimediaRepository.FindAllDetailsByHotelId(query.HotelId);

    public async Task<Multimedia?> Handle(GetMainMultimediaByHotelIdQuery query)
        => await multimediaRepository.FindMainByHotelId(query.HotelId);

    public async Task<Multimedia?> Handle(GetLogoMultimediaByHotelIdQuery query)
        => await multimediaRepository.FindLogoByHotelId(query.HotelId);

}