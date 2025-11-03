using SweetManagerWebService.Inventory.Domain.Model.Commands;
using SweetManagerWebService.Inventory.Interfaces.REST.Resources;

namespace SweetManagerWebService.Inventory.Interfaces.REST.Transform
{
    public static class UpdateProviderOnSupplyCommandFromResourceAssembler
    {
        public static UpdateProviderOnSupplyCommand ToCommandFromResource(int id, UpdateProviderOnSupplyResource resource)
        {
            return new UpdateProviderOnSupplyCommand(id, resource.ProviderId);
        }
    }
}
