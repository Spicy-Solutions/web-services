namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

public record CreateHotelCommand(
    int OwnerId,
    string Name,
    string Description,
    string Email,
    string Address,
    string Phone,
    string Category
    );