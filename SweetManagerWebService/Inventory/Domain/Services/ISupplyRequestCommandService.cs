using SweetManagerWebService.Inventory.Domain.Model.Commands;

namespace SweetManagerWebService.Inventory.Domain.Services;

public interface ISupplyRequestCommandService
{
    Task<bool> Handle(CreateSupplyRequestCommand command);
}