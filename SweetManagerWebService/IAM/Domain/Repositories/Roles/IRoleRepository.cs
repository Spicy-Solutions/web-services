using SweetManagerWebService.IAM.Domain.Model.Entities.Roles;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Domain.Repositories.Roles
{
    public interface IRoleRepository : IBaseRepository<Role>
    {

        Task<Role?> FindByNameAsync(string name);

        Task<int?> FindIdByNameAsync(string name);
    }
}