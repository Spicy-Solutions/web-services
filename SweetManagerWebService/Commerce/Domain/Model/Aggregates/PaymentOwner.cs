using System;
using System.Collections.Generic;
using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.Inventory.Domain.Model.Entities;

namespace SweetManagerWebService.Commerce.Domain.Model.Aggregates;

public partial class PaymentOwner
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public string? Description { get; set; }

    public decimal? FinalAmount { get; set; }

    public virtual Owner? Owner { get; set; }

    public virtual ICollection<SupplyRequest> SupplyRequests { get; set; } = new List<SupplyRequest>();
    
    public PaymentOwner(int? ownerId, string? description, decimal? finalAmount)
    {
        OwnerId = ownerId;
        Description = description;
        FinalAmount = finalAmount;
    }
    
    public PaymentOwner(CreatePaymentOwnerCommand command)
    {
        OwnerId = command.OwnerId;
        Description = command.Description;
        FinalAmount = command.FinalAmount;
    }
    
    public PaymentOwner(UpdatePaymentOwnerCommand command)
    {
        Id = command.Id;
        OwnerId = command.OwnerId;
        Description = command.Description;
        FinalAmount = command.FinalAmount;
    }
}
