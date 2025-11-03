using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Queries.Users;

namespace SweetManagerWebService.IAM.Domain.Services.QueryServices.Users
{
    public interface IGuestQueryService
    {
        Task<dynamic> Handle(GetAllFilteredUsersQuery query);

        Task<IEnumerable<Guest>> Handle(GetAllUsersFromOrganizationQuery query);

        Task<Guest?> Handle(GetUserByIdQuery query);

    }
}