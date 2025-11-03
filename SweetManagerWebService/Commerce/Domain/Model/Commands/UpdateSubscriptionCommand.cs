using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;

namespace SweetManagerWebService.Commerce.Domain.Model.Commands;

public record UpdateSubscriptionCommand(
    int Id,
    ESubscriptionTypes Name, 
    string? Content, 
    decimal? Price, 
    EStates Status);