namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

public record CreateMultimediaCommand(int HotelId, string? Url, string Type, int Position);