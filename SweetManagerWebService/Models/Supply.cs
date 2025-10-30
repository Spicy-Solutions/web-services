using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Supply
{
    public int Id { get; set; }

    public int ProviderId { get; set; }

    public int HotelId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public string State { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;

    public virtual Provider Provider { get; set; } = null!;

    public virtual ICollection<SupplyRequest> SupplyRequests { get; set; } = new List<SupplyRequest>();
}
