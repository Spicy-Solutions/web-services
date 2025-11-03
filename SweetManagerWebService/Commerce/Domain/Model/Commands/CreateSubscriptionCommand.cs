using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;

namespace SweetManagerWebService.Commerce.Domain.Model.Commands;

public record CreateSubscriptionCommand(
    ESubscriptionTypes Name, 
    string? Content, 
    decimal? Price, 
    EStates Status);