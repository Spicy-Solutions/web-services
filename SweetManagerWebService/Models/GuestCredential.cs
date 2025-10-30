using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class GuestCredential
{
    public int GuestId { get; set; }

    public string? Code { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Guest Guest { get; set; } = null!;
}
