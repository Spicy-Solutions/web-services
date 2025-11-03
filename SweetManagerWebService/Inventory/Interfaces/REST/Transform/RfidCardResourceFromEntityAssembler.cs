using SweetManagerWebService.Inventory.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Interfaces.REST.Resources;

namespace SweetManagerWebService.Inventory.Interfaces.REST.Transform;

public static class RfidCardResourceFromEntityAssembler
{
    public static RfidCardResource ToResourceFromEntity(RfidCard rfidCard)
    {
        return new RfidCardResource(
            rfidCard.Id,
            rfidCard.RoomId,
            rfidCard.apiKey,
            rfidCard.uId);
    }
}