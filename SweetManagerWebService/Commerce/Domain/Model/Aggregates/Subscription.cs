using System;
using System.Collections.Generic;
using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Domain.Model.Entities;
using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;

namespace SweetManagerWebService.Commerce.Domain.Model.Aggregates;

public partial class Subscription
{
    public int Id { get; set; }

    public ESubscriptionTypes Name { get; set; }

    public string? Content { get; set; }

    public decimal? Price { get; set; }

    public EStates Status { get; set; }

    public virtual ICollection<ContractOwner> ContractOwners { get; set; } = new List<ContractOwner>();
    
    public Subscription(ESubscriptionTypes name, string? content, decimal? price, EStates status)
    {
        Name = name;
        Content = content;
        Price = price;
        Status = status;
    }
    
    public Subscription(CreateSubscriptionCommand command)
    {
        Name = command.Name;
        Content = command.Content;
        Price = command.Price;
        Status = command.Status;
    }
    
    public Subscription(UpdateSubscriptionCommand command)
    {
        Id = command.Id;
        Name = command.Name;
        Content = command.Content;
        Price = command.Price;
        Status = command.Status;
    }
}
