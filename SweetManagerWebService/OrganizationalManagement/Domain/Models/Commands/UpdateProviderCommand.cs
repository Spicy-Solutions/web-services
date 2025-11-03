namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

public record UpdateProviderCommand(int Id, string Name, string Email, string Phone);