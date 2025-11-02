namespace SweetManagerWebService.Inventory.Domain.Model.Exceptions.Supply;

public class SupplyNotFoundException : Exception
{
    public SupplyNotFoundException(string message) : base(message)
    {
    }
}