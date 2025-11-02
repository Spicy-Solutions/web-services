using SweetManagerIotWebService.API.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerIotWebService.API.Commerce.Domain.Repositories;

public interface IPaymentOwnerRepository : IBaseRepository<PaymentOwner>
{
    Task<IEnumerable<PaymentOwner>> FindByOwnerIdAsync(int ownerId);
}