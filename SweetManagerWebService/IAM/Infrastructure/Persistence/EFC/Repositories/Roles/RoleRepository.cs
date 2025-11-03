using Microsoft.EntityFrameworkCore;
using SweetManagerWebService.IAM.Domain.Model.Entities.Roles;
using SweetManagerWebService.IAM.Domain.Repositories.Roles;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Configuration;
using SweetManagerWebService.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace SweetManagerWebService.IAM.Infrastructure.Persistence.EFC.Repositories.Roles
{
    public class RoleRepository(SweetManagerContext context) : BaseRepository<Role>(context), IRoleRepository
    {
        public async Task<Role?> FindByNameAsync(string name)
        => await Context.Set<Role>().Where(r => r.Name.Equals(name)).FirstOrDefaultAsync();

        public async Task<int?> FindIdByNameAsync(string name)
        {
            var result = await Context.Set<Role>().Where(r => r.Name.Equals(name)).FirstOrDefaultAsync();

            return result?.Id;
        }
    }
}
