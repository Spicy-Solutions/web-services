using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Commands;

namespace SweetManagerWebService.Inventory.Domain.Services;

public interface IRfidCardCommandService
{
    Task<RfidCard?> Handle(CreateRfidCardCommand command);
}