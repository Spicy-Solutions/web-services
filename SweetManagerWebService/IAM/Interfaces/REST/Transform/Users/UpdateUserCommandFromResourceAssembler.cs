using SweetManagerWebService.IAM.Domain.Model.Commands.Authentication;
using SweetManagerWebService.IAM.Interfaces.REST.Resources.Users;

namespace SweetManagerWebService.IAM.Interfaces.REST.Transform.Users
{
    public static class UpdateUserCommandFromResourceAssembler
    {
        public static UpdateUserCommand ToCommandFromResource(UpdateUserResource resource, int id)
        {
            return new UpdateUserCommand(id, resource.Name, resource.Surname,
                resource.Phone, resource.Email, resource.State, resource.PhotoURL);
        }
    }
}