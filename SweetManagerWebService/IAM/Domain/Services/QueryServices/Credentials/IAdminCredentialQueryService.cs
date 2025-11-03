using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Model.Queries.Credentials;

namespace SweetManagerWebService.IAM.Domain.Services.QueryServices.Credentials
{
    public interface IAdminCredentialQueryService
    {
        Task<AdminCredential?> Handle(GetUserCredentialByIdQuery query);
    }
}