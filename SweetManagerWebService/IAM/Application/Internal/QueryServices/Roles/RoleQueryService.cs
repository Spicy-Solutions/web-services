using SweetManagerWebService.IAM.Domain.Model.Entities.Roles;
using SweetManagerWebService.IAM.Domain.Model.Queries.Roles;
using SweetManagerWebService.IAM.Domain.Repositories.Roles;
using SweetManagerWebService.IAM.Domain.Services.QueryServices.Roles;

namespace SweetManagerWebService.IAM.Application.Internal.QueryServices.Roles
{
    public class RoleQueryService(IRoleRepository roleRepository) : IRoleQueryService
    {
        public async Task<IEnumerable<Role>> Handle(GetAllRolesQuery query)
         => await roleRepository.ListAsync();

        public async Task<Role?> Handle(GetRoleByNameQuery query)
         => await roleRepository.FindByNameAsync(query.Name);

        public async Task<int?> Handle(GetRoleIdByNameQuery query)
         => await roleRepository.FindIdByNameAsync(query.Name);
    }
}
