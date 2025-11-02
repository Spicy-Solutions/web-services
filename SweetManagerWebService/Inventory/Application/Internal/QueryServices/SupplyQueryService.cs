using SweetManagerWebService.Inventory.Domain.Model.Queries.Supply;
using SweetManagerWebService.Inventory.Domain.Repositories;
using SweetManagerWebService.Inventory.Domain.Services;

namespace SweetManagerWebService.Inventory.Application.Internal.QueryServices;

public class SupplyQueryService(ISupplyRepository supplyRepository) : ISupplyQueryService
{
   public async Task<Domain.Model.Aggregates.Supply?> Handle(GetSupplyByIdQuery query)
   {
      return await supplyRepository.FindByIdAsync(query.Id);
   }
   
   public async Task<IEnumerable<Domain.Model.Aggregates.Supply>> Handle(GetAllSuppliesQuery query)
   {
      return await supplyRepository.FindSuppliesByHotelIdAsync(query.HotelId);
   }
   
   public async Task<IEnumerable<Domain.Model.Aggregates.Supply>> Handle(GetSupplyByProviderIdQuery query)
   {
      return await supplyRepository.FindByProviderId(query.ProviderId);
   }
   
}