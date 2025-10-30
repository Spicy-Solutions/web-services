using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class ContractOwner
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinalDate { get; set; }

    public int? SubscriptionId { get; set; }

    public int Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Owner? Owner { get; set; }

    public virtual Subscription? Subscription { get; set; }
}
