using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;
using SweetManagerWebService.IAM.Domain.Model.Queries.Preferences;
using SweetManagerWebService.IAM.Domain.Model.Queries.Users;
using SweetManagerWebService.IAM.Domain.Services.QueryServices.Preferences;
using SweetManagerWebService.IAM.Domain.Services.QueryServices.Users;

namespace SweetManagerWebService.IAM.Interfaces.ACL.Services
{
    public class IamContextFacade(IAdminQueryService adminQueryService, IOwnerQueryService ownerQueryService,
        IGuestPreferenceQueryService guestPreferenceQueryService) : IIamContextFacade
    {
        public async Task<Admin?> FetchAdminByUserId(int id)
        {
            try
            {
                var admin = await adminQueryService.Handle(new GetUserByIdQuery(id));

                return admin;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public async Task<GuestPreference?> FetchGuestPreferenceById(int id)
        {
            try
            {
                var guestPreference = await guestPreferenceQueryService.Handle(new GetGuestPreferenceByGuestIdQuery(id));

                return guestPreference;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public async Task<Owner?> FetchOwnerByUserId(int id)
        {
            try
            {
                var owner = await ownerQueryService.Handle(new GetUserByIdQuery(id));

                return owner;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
