using SweetManagerWebService.IAM.Domain.Model.Entities.Roles;
using SweetManagerWebService.IAM.Domain.Model.Queries.Roles;

namespace SweetManagerWebService.IAM.Domain.Services.QueryServices.Roles
{
    public interface IRoleQueryService
    {
        Task<IEnumerable<Role>> Handle(GetAllRolesQuery query);

        Task<Role?> Handle(GetRoleByNameQuery query);

        Task<int?> Handle(GetRoleIdByNameQuery query);
    }
}