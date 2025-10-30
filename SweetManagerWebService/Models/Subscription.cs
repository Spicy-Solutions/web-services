using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Subscription
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Content { get; set; }

    public decimal? Price { get; set; }

    public int Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ContractOwner> ContractOwners { get; set; } = new List<ContractOwner>();
}
