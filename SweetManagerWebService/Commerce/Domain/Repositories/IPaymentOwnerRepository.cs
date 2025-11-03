using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Shared.Domain.Repositories;

namespace SweetManagerWebService.Commerce.Domain.Repositories;

public interface IPaymentOwnerRepository : IBaseRepository<PaymentOwner>
{
    Task<IEnumerable<PaymentOwner>> FindByOwnerIdAsync(int ownerId);
}