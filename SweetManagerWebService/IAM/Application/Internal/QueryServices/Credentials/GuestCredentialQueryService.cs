using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Queries.Credentials;
using SweetManagerWebService.IAM.Domain.Repositories.Credentials;
using SweetManagerWebService.IAM.Domain.Services.QueryServices.Credentials;

namespace SweetManagerWebService.IAM.Application.Internal.QueryServices.Credentials
{
    public class GuestCredentialQueryService(IGuestCredentialRepository guestCredentialRepository) : IGuestCredentialQueryService
    {
        public async Task<GuestCredential?> Handle(GetUserCredentialByIdQuery query)
         => await guestCredentialRepository.FindByIdAsync(query.Id);
    }
}
