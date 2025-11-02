
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Services;

public interface IProviderCommandService
{
    Task<Provider?> Handle(CreateProviderCommand command);
    Task<Provider?> Handle(UpdateProviderCommand command);
    Task<bool> Handle(DeleteProviderCommand command);
}