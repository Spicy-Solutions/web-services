using SweetManagerWebService.Commerce.Interfaces.REST.Resources;

namespace SweetManagerWebService.Commerce.Interfaces.REST.Transform;

public static class ComparativeWeeklyIncomeResourceFromEntityAssembler
{
    public static ComparativeWeeklyIncomeResource ToResourceFromEntity(dynamic entity)
    {
        return new ComparativeWeeklyIncomeResource(entity.week_number, entity.total_income, entity.total_expense,
            entity.total_profit);
    }
}