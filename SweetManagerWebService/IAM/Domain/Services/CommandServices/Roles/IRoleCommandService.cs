using SweetManagerWebService.IAM.Domain.Model.Commands.Roles;
using SweetManagerWebService.IAM.Domain.Model.Entities.Roles;

namespace SweetManagerWebService.IAM.Domain.Services.CommandServices.Roles
{
    public interface IRoleCommandService
    {
        Task<bool> Handle(SeedRolesCommand command);

    }
}