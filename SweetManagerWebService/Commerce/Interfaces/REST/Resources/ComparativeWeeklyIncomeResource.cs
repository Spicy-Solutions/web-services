namespace SweetManagerWebService.Commerce.Interfaces.REST.Resources;

public record ComparativeWeeklyIncomeResource(int? WeekNumbers, decimal TotalIncome, decimal TotalExpense, decimal TotalProfit);