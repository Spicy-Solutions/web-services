using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class TypeRoom
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
