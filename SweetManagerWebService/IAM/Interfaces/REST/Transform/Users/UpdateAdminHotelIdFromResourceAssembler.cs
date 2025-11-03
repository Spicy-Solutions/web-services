using SweetManagerWebService.IAM.Domain.Model.Commands.Authentication;
using SweetManagerWebService.IAM.Interfaces.REST.Resources.Users;

namespace SweetManagerWebService.IAM.Interfaces.REST.Transform.Users
{
    public static class UpdateAdminHotelIdFromResourceAssembler
    {
        public static UpdateAdminHotelIdCommand ToCommandFromResource(UpdateAdminHotelIdResource resource, int id)
        {
            return new UpdateAdminHotelIdCommand(id, resource.HotelId);
        }
    }
}