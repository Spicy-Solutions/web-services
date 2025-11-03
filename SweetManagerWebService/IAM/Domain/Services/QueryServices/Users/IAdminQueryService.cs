using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Queries.Users;

namespace SweetManagerWebService.IAM.Domain.Services.QueryServices.Users
{
    public interface IAdminQueryService
    {
        Task<IEnumerable<Admin>> Handle(GetAllUsersFromOrganizationQuery query);

        Task<dynamic> Handle(GetAllFilteredUsersQuery query);

        Task<Admin?> Handle(GetUserByIdQuery query);
    }
}