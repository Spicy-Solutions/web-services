namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

public record UpdateMultimediaCommand(int Id, int HotelId, string? Url, string Type, int Position);