using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Domain.Model.Entities;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Commerce.Domain.Services;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Commerce.Application.Internal.CommandServices;

public class ContractOwnerCommandService(
    IContractOwnerRepository contractOwnerRepository,
    IUnitOfWork unitOfWork) : IContractOwnerCommandService
{
    public async Task<ContractOwner?> Handle(CreateContractOwnerCommand command)
    {
        var contractOwner = new ContractOwner(command);
        try
        {
            await contractOwnerRepository.AddAsync(contractOwner);
            await unitOfWork.CommitAsync();
            return contractOwner;
        } catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the contract owner: {e.Message}");
            return null;
        }
    }

    public async Task<ContractOwner?> Handle(UpdateContractOwnerCommand command)
    {
        var contractOwner = await contractOwnerRepository.FindByIdAsync(command.Id);
        if (contractOwner == null)
        {
            Console.WriteLine($"Payment Customer with ID {command.Id} not found.");
            return null;
        }

        var newContractOwner = new ContractOwner(command);

        try
        {
            contractOwnerRepository.Remove(contractOwner);
            await contractOwnerRepository.AddAsync(newContractOwner);
            await unitOfWork.CommitAsync();
            return newContractOwner;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while updating the contract owner: {e.Message}");
            return null;
        }
    }
}