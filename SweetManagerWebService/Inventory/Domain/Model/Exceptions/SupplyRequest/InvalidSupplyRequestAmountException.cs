namespace SweetManagerWebService.Inventory.Domain.Model.Exceptions.SupplyRequest;

public class InvalidSupplyRequestAmountException : Exception
{
    public InvalidSupplyRequestAmountException(string message) : base(message)
    {
    }
}