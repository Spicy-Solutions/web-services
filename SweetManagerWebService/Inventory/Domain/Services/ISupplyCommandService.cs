using SweetManagerWebService.Inventory.Domain.Model.Commands;

namespace SweetManagerWebService.Inventory.Domain.Services;

public interface ISupplyCommandService
{
    Task<bool> Handle(CreateSupplyCommand command);
    Task<bool> Handle(UpdateSupplyCommand command);

    Task<bool> Handle(UpdateProviderOnSupplyCommand command);
}