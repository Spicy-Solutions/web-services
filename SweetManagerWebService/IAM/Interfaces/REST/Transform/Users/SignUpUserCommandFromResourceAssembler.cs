using SweetManagerWebService.IAM.Domain.Model.Commands.Authentication;
using SweetManagerWebService.IAM.Interfaces.REST.Resources.Users;

namespace SweetManagerWebService.IAM.Interfaces.REST.Transform.Users
{
    public static class SignUpUserCommandFromResourceAssembler
    {
        public static SignUpUserCommand ToCommandFromResource(SignUpUserResource resource)
        {
            return new(resource.Id, resource.Name, resource.Surname, resource.Phone,
                resource.Email, resource.Password, "");
        }
    }
}