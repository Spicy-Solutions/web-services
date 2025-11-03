using SweetManagerWebService.Commerce.Domain.Model.Queries;

namespace SweetManagerWebService.Commerce.Domain.Services;

public interface IDashboardQueryService
{
    
    Task<IEnumerable<dynamic>> Handle(GetWeeklyIncomesByHotelIdQuery query);
    
    
    Task<IEnumerable<dynamic>> Handle(GetMonthlyIncomesByHotelIdQuery query);
}