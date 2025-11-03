
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Repositories;

public interface IMultimediaRepository : IBaseRepository<Multimedia>
{
    Task<IEnumerable<Multimedia>> FindAllDetailsByHotelId(int hotelId);

    Task<Multimedia?> FindMainByHotelId(int hotelId);
        
    Task<Multimedia?> FindLogoByHotelId(int hotelId);
}