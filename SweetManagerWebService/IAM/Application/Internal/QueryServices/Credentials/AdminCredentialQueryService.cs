using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Queries.Credentials;
using SweetManagerWebService.IAM.Domain.Repositories.Credentials;
using SweetManagerWebService.IAM.Domain.Services.QueryServices.Credentials;

namespace SweetManagerWebService.IAM.Application.Internal.QueryServices.Credentials
{
    public class AdminCredentialQueryService(IAdminCredentialRepository adminCredentialRepository) : IAdminCredentialQueryService
    {
        public async Task<AdminCredential?> Handle(GetUserCredentialByIdQuery query)
         => await adminCredentialRepository.FindByIdAsync(query.Id);
    }
}