namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

public record UpdateHotelCommand(
    int HotelId,
    string Description,
    string Email,
    string Address,
    string Phone,
    int OwnerId,
    string Category);