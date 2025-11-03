using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;

namespace SweetManagerWebService.Commerce.Domain.Model.Queries;

public record GetAllSubscriptionsByNameQuery(ESubscriptionTypes Name);