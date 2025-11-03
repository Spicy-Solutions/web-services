namespace SweetManagerWebService.Communication.Domain.Model.Commands
{
    public record CreateAdminRequestToOrganizationCommand(int AdminId, string AdditionalMessage, int HotelId);
}