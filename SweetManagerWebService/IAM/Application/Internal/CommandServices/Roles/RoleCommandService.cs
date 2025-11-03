using SweetManagerWebService.IAM.Domain.Model.Commands.Roles;
using SweetManagerWebService.IAM.Domain.Model.Entities.Roles;
using SweetManagerWebService.IAM.Domain.Model.ValueObjects;
using SweetManagerWebService.IAM.Domain.Repositories.Roles;
using SweetManagerWebService.IAM.Domain.Services.CommandServices.Roles;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.IAM.Application.Internal.CommandServices.Roles
{
    public class RoleCommandService(IRoleRepository roleRepository,
        IUnitOfWork unitOfWork) : IRoleCommandService
    {
        public async Task<bool> Handle(SeedRolesCommand command)
        {
            foreach (var role in Enum.GetValues(typeof(ERoles)))
            {
                if (await roleRepository.FindByNameAsync(role.ToString()!) is null)
                {
                    await roleRepository.AddAsync(new Role(role.ToString()!));
                }
            }

            await unitOfWork.CommitAsync();

            return true;
        }
    }
}
