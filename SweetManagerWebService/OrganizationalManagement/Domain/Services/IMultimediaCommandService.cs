using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Services;

public interface IMultimediaCommandService
{
    Task<Multimedia?> Handle(CreateMultimediaCommand command);

    Task<Multimedia?> Handle(UpdateMultimediaCommand command);
}