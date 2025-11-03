using SweetManagerWebService.Commerce.Domain.Model.Queries;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Commerce.Domain.Services;

namespace SweetManagerWebService.Commerce.Application.Internal.QueryServices;

public class DashboardQueryService(IDashboardRepository dashboardRepository) : IDashboardQueryService
{
    public async Task<IEnumerable<dynamic>> Handle(GetWeeklyIncomesByHotelIdQuery query)
    {
        return await dashboardRepository.FindWeeklyComparativeIncomesAsync(query.HotelId);
    }

    public async Task<IEnumerable<dynamic>> Handle(GetMonthlyIncomesByHotelIdQuery query)
    {
        return await dashboardRepository.FindMonthlyComparativeIncomesAsync(query.HotelId);
    }
}