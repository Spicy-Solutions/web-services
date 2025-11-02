namespace SweetManagerWebService.Inventory.Domain.Model.Exceptions.Supply;

public class InvalidSupplyPriceException : Exception
{
    public InvalidSupplyPriceException(string message) : base(message)
    {
    }
}