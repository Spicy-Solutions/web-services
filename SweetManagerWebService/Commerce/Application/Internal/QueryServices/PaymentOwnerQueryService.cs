using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Queries;
using SweetManagerWebService.Commerce.Domain.Repositories;
using SweetManagerWebService.Commerce.Domain.Services;

namespace SweetManagerWebService.Commerce.Application.Internal.QueryServices;

public class PaymentOwnerQueryService(IPaymentOwnerRepository paymentOwnerRepository) : IPaymentOwnerQueryService
{
    public async Task<IEnumerable<PaymentOwner>> Handle(GetAllPaymentOwnersQuery query)
    {
        return await paymentOwnerRepository.ListAsync();
    }

    public async Task<PaymentOwner?> Handle(GetPaymentOwnerByIdQuery query)
    {
        return await paymentOwnerRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<PaymentOwner>> Handle(GetAllPaymentOwnersByOwnerIdQuery query)
    {
        return await paymentOwnerRepository.FindByOwnerIdAsync(query.OwnerId);
    }
}