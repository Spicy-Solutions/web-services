namespace SweetManagerWebService.Inventory.Domain.Model.Exceptions.SupplyRequest;

public class InvalidSupplyRequestCountException : Exception
{
    public InvalidSupplyRequestCountException(string message) : base(message)
    {
    }
}