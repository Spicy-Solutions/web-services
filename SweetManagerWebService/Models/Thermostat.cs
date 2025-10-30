using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Thermostat
{
    public int Id { get; set; }

    public int? RoomId { get; set; }

    public double? Temperature { get; set; }

    public string? IpAddress { get; set; }

    public string? MacAddress { get; set; }

    public string? State { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual Room? Room { get; set; }
}
