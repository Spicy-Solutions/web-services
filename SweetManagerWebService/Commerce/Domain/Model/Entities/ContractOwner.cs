using System;
using System.Collections.Generic;
using SweetManagerWebService.Commerce.Domain.Model.Aggregates;
using SweetManagerWebService.Commerce.Domain.Model.Commands;
using SweetManagerWebService.Commerce.Domain.Model.ValueObjects;
using SweetManagerWebService.IAM.Domain.Model.Aggregates;

namespace SweetManagerWebService.Commerce.Domain.Model.Entities;

public partial class ContractOwner
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinalDate { get; set; }

    public int? SubscriptionId { get; set; }

    public EStates Status { get; set; }

    public virtual Owner? Owner { get; set; }

    public virtual Subscription? Subscription { get; set; }
    
    public ContractOwner(
        int? ownerId, 
        DateTime? startDate, 
        DateTime? finalDate, 
        int? subscriptionId, 
        EStates status)
    {
        OwnerId = ownerId;
        StartDate = startDate;
        FinalDate = finalDate;
        SubscriptionId = subscriptionId;
        Status = status;
    }
    
    public ContractOwner(CreateContractOwnerCommand command)
    {
        OwnerId = command.OwnerId;
        StartDate = command.StartDate;
        FinalDate = command.FinalDate;
        SubscriptionId = command.SubscriptionId;
        Status = command.Status;
    }
    
    public ContractOwner(UpdateContractOwnerCommand command)
    {
        Id = command.Id;
        OwnerId = command.OwnerId;
        StartDate = command.StartDate;
        FinalDate = command.FinalDate;
        SubscriptionId = command.SubscriptionId;
        Status = command.Status;
    }
}
