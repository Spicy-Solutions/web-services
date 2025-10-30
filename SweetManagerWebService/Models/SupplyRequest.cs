using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class SupplyRequest
{
    public int Id { get; set; }

    public int PaymentOwnerId { get; set; }

    public int SupplyId { get; set; }

    public int Count { get; set; }

    public decimal Amount { get; set; }

    public virtual PaymentOwner PaymentOwner { get; set; } = null!;

    public virtual Supply Supply { get; set; } = null!;
}
