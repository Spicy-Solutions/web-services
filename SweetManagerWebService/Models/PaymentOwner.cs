using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class PaymentOwner
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public string? Description { get; set; }

    public decimal? FinalAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Owner? Owner { get; set; }

    public virtual ICollection<SupplyRequest> SupplyRequests { get; set; } = new List<SupplyRequest>();
}
