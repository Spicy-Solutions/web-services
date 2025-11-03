using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Queries.Credentials;
using SweetManagerWebService.IAM.Domain.Repositories.Credentials;
using SweetManagerWebService.IAM.Domain.Services.QueryServices.Credentials;

namespace SweetManagerWebService.IAM.Application.Internal.QueryServices.Credentials
{
    public class OwnerCredentialQueryService(IOwnerCredentialRepository ownerCredentialRepository) : IOwnerCredentialQueryService
    {
        public async Task<OwnerCredential?> Handle(GetUserCredentialByIdQuery query)
         => await ownerCredentialRepository.FindByIdAsync(query.Id);
    }
}
