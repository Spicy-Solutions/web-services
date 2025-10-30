using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Provider
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? State { get; set; }

    public int HotelId { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;

    public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();
}
