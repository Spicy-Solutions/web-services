namespace SweetManagerWebService.Communication.Interfaces.REST.Resources
{
    public record CreateAdminRequestToOrganizationResource(int AdminId, string AdditionalMessage, int HotelId);
}
