using SweetManagerWebService.Communication.Domain.Model.Commands;
using SweetManagerWebService.Communication.Interfaces.REST.Resources;

namespace SweetManagerWebService.Communication.Interfaces.REST.Transform
{
    public static class CreateAdminRequestCommandFromResourceAssembler
    {
        public static CreateAdminRequestToOrganizationCommand ToCommandFromResource(CreateAdminRequestToOrganizationResource resource)
        {
            return new CreateAdminRequestToOrganizationCommand(resource.AdminId, resource.AdditionalMessage, resource.HotelId);
        }
    }
}
