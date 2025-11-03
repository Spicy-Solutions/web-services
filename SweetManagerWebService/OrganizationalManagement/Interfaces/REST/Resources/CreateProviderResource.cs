namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

public record CreateProviderResource(string Name,
    string Email,
    string Phone,
    string State,
    int HotelId);