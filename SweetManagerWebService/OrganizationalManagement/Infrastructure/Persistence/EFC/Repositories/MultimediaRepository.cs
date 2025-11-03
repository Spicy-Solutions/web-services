using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Infrastructure.Persistence.EFC.Repositories;

public class MultimediaRepository(SweetManagerContext context) : BaseRepository<Multimedia>(context),
    IMultimediaRepository
{
    public async Task<IEnumerable<Multimedia>> FindAllDetailsByHotelId(int hotelId)
        => await Context.Set<Multimedia>().Where(m => m.HotelId.Equals(hotelId) && 
                                                      m.Type == Domain.Models.ValueObjects.ETypeMultimedia.DETAIL).ToListAsync();


    public async Task<Multimedia?> FindMainByHotelId(int hotelId)
        => await Context.Set<Multimedia>().Where(m => m.HotelId.Equals(hotelId) && 
                                                      m.Type == Domain.Models.ValueObjects.ETypeMultimedia.MAIN).FirstOrDefaultAsync();
        
    public async Task<Multimedia?> FindLogoByHotelId(int hotelId)
        => await Context.Set<Multimedia>().Where(m => m.HotelId.Equals(hotelId) && 
                                                      m.Type == Domain.Models.ValueObjects.ETypeMultimedia.LOGO).FirstOrDefaultAsync();
}