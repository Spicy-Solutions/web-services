using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;

namespace SweetManagerWebService.IAM.Interfaces.ACL
{
    public interface IIamContextFacade
    {
        Task<Admin?> FetchAdminByUserId(int id);

        Task<Owner?> FetchOwnerByUserId(int id);

        Task<GuestPreference?> FetchGuestPreferenceById(int id);

    }
}
