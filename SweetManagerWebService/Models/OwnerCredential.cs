using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class OwnerCredential
{
    public int OwnerId { get; set; }

    public string? Code { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Owner Owner { get; set; } = null!;
}
