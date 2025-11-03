using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Entities;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.OrganizationalManagement.Domain.Services;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Application.Internal.CommandServices;

public class FogServerCommandService(IFogServerRepository fogServerRepository, IUnitOfWork unitOfWork)
    : IFogServerCommandService
{
    public async Task<FogServer?> Handle(CreateFogServerCommand command)
    {
        if (string.IsNullOrEmpty(command.IpAddress) || string.IsNullOrEmpty(command.SubnetMask) ||
            command.HotelId.Equals(0))
            throw new ArgumentException("All the fields are required.");

        var entity = new FogServer(command);

        await fogServerRepository.AddAsync(entity);

        await unitOfWork.CommitAsync();

        return entity;
    }

    public async Task<FogServer?> Handle(UpdateFogServerCommand command)
    {
        if (command.Id.Equals(0) || string.IsNullOrEmpty(command.IpAddress) || string.IsNullOrEmpty(command.SubnetMask))
            throw new ArgumentException("All the fields are required.");

        var entity = await fogServerRepository.FindByIdAsync(command.Id) ??
                     throw new ArgumentException("No one fog server exist with the given id");

        entity.Update(command);

        fogServerRepository.Update(entity);

        await unitOfWork.CommitAsync();

        return entity;
    }
}