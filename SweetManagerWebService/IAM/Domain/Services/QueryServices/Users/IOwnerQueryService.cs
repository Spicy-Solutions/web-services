using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Queries.Users;

namespace SweetManagerWebService.IAM.Domain.Services.QueryServices.Users
{
    public interface IOwnerQueryService
    {
        Task<dynamic> Handle(GetAllFilteredUsersQuery query);

        Task<Owner?> Handle(GetUserByIdQuery query);

        Task<Owner?> Handle(GetOwnerFromAnOrganizationQuery query);
        
    }
}