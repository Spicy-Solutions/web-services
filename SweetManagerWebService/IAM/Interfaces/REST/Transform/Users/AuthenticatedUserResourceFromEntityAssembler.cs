using SweetManagerWebService.IAM.Interfaces.REST.Resources.Users;

namespace SweetManagerWebService.IAM.Interfaces.REST.Transform.Users
{
    public static class AuthenticatedUserResourceFromEntityAssembler
    {
        public static AuthenticatedUserResource ToResourceFromEntity(dynamic entity, string token)
        {
            return new AuthenticatedUserResource(entity.Id, entity.Email, token);
        }
    }
}