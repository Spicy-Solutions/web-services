namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

public record CreateFogServerCommand(string IpAddress, string SubnetMask, int HotelId);