namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

public record CreateProviderCommand(
    string Name,
    string Email,
    string Phone,
    string State,
    int HotelId
    );