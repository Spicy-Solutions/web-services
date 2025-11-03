using SweetManagerWebService.IAM.Domain.Model.Entities.Credentials;
using SweetManagerWebService.IAM.Domain.Repositories.Credentials;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.IAM.Infrastructure.Persistence.EFC.Repositories.Credentials
{
    public class GuestCredentialRepository(SweetManagerContext context) : BaseRepository<GuestCredential>(context),
        IGuestCredentialRepository
    {

    }
}