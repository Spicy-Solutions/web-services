namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

public record UpdateFogServerCommand(int Id, string IpAddress, string SubnetMask);