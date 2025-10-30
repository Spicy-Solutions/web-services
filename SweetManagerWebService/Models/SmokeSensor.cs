using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class SmokeSensor
{
    public int Id { get; set; }

    public int? RoomId { get; set; }

    public string? IpAddress { get; set; }

    public double? LastAnalogicValue { get; set; }

    public string? MacAddress { get; set; }

    public string? State { get; set; }

    public DateTime? LastAlertTime { get; set; }

    public virtual Room? Room { get; set; }
}
