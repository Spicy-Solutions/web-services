using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class AdminCredential
{
    public int AdminId { get; set; }

    public string? Code { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Admin Admin { get; set; } = null!;
}
