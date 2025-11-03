using SweetManagerWebService.OrganizationalManagement.Application.Internal.OutboundServices.ACL;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Queries;
using SweetManagerWebService.OrganizationalManagement.Domain.Services;

namespace SweetManagerWebService.OrganizationalManagement.Interfaces.ACL.Services;

public class OrganizationManagementContextFacade(IHotelQueryService hotelQueryService, ExternalIamService externalIamService) : IOrganizationManagementContextFacade
{
    public async Task<int> FetchOwnerIdByHotelId(int hotelId)
    {
        try
        {
            var hotel = await hotelQueryService.Handle(new GetHotelByIdQuery(hotelId));

            if (hotel is null) return 0;

            return hotel.OwnerId;
        }
        catch(Exception)
        {
            return 0;
        }
    }
}