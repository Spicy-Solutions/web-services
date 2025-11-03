using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Services;

public interface IFogServerCommandService
{
    Task<FogServer?> Handle(CreateFogServerCommand command);

    Task<FogServer?> Handle(UpdateFogServerCommand command);
}