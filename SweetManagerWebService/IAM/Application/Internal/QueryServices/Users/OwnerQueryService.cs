using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Queries.Users;
using SweetManagerWebService.IAM.Domain.Repositories.Users;
using SweetManagerWebService.IAM.Domain.Services.QueryServices.Users;

namespace SweetManagerWebService.IAM.Application.Internal.QueryServices.Users
{
    public class OwnerQueryService(IOwnerRepository ownerRepository) : IOwnerQueryService
    {
        public async Task<dynamic> Handle(GetAllFilteredUsersQuery query)
         => await ownerRepository.FindAllByFiltersAsync(query.Email, query.Phone, query.State);

        public async Task<Owner?> Handle(GetUserByIdQuery query)
         => await ownerRepository.FindByIdAsync(query.Id);

        public async Task<Owner?> Handle(GetOwnerFromAnOrganizationQuery query)
         => await ownerRepository.FindByHotelIdAsync(query.HotelId);

    }
}