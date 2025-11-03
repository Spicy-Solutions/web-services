namespace SweetManagerWebService.OrganizationalManagement.Interfaces.REST.Resources;

public record CreateMultimediaResource(int HotelId, string? Url, string Type, int Position);