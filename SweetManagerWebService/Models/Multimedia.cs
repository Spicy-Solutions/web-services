using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Multimedia
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public string? Url { get; set; }

    public string Type { get; set; } = null!;

    public int Position { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;
}
