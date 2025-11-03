using SweetManagerWebService.IAM.Domain.Model.Commands.Authentication;
using SweetManagerWebService.IAM.Interfaces.REST.Resources.Users;

namespace SweetManagerWebService.IAM.Interfaces.REST.Transform.Users
{
    public static class SignInCommandFromResourceAssembler
    {
        public static SignInUserCommand ToCommandFromResource(SignInResource resource)
        {
            return new SignInUserCommand(resource.Email, resource.Password, resource.RoleId);
        }
    }
}