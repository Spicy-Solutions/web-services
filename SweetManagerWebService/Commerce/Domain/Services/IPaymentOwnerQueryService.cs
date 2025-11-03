using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Queries;

namespace SweetManagerWebService.Commerce.Domain.Services;

public interface IPaymentOwnerQueryService
{
    Task<IEnumerable<PaymentOwner>> Handle(GetAllPaymentOwnersQuery query);
    Task<PaymentOwner?> Handle(GetPaymentOwnerByIdQuery query);
    Task<IEnumerable<PaymentOwner>> Handle(GetAllPaymentOwnersByOwnerIdQuery query);
}