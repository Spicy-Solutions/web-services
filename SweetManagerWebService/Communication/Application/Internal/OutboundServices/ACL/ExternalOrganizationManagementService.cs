using SweetManagerWebService.Communication.Domain.Model.ValueObjects;
using SweetManagerWebService.OrganizationalManagement.Interfaces.ACL;

namespace SweetManagerWebService.Communication.Application.Internal.OutboundServices.ACL
{
    public class ExternalOrganizationManagementService(IOrganizationManagementContextFacade organizationManagementContextFacade)
    {
        public async Task<OwnerContact?> FetchOwnerIdByHotelId(int hotelId)
        {
            try
            {
                var ownerId = await organizationManagementContextFacade.FetchOwnerIdByHotelId(hotelId);

                if (ownerId is 0) return await Task.FromResult<OwnerContact?>(null);

                return new OwnerContact(ownerId);
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
