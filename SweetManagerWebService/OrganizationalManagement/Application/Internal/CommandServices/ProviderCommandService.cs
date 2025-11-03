
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Domain.Repositories;
using SweetManagerWebService.OrganizationalManagement.Domain.Services;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.OrganizationalManagement.Application.Internal.CommandServices;

public class ProviderCommandService(IProviderRepository providerRepository, IUnitOfWork unitOfWork) : IProviderCommandService
{
    public async Task<Provider?> Handle(CreateProviderCommand command)
    {
        var provider = new Provider(command);
        
        await providerRepository.AddAsync(provider);
        await unitOfWork.CommitAsync();
        return provider;
    }
    
    public async Task<Provider?> Handle(UpdateProviderCommand command)
    {
        var provider = await providerRepository.FindByIdAsync(command.Id);
        if (provider == null)
        {
            throw new Exception($"Provider with ID {command.Id} not found.");
        }

        provider.UpdateData(command);
        providerRepository.Update(provider);
        await unitOfWork.CommitAsync();
        return provider;
    }
    
    public async Task<bool> Handle(DeleteProviderCommand command)
    {
        var provider = await providerRepository.FindByIdAsync(command.ProviderId);
        if (provider == null)
        {
            throw new Exception($"Provider with ID {command.ProviderId} not found.");
        }

        if(!provider.IsActive()) 
        {
            throw new Exception($"Provider with ID {command.ProviderId} is already inactive.");
        }
        
        provider.DisableProvider();
        providerRepository.Update(provider);
        await unitOfWork.CommitAsync();
        return true;
    }
}