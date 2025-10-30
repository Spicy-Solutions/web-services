using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Room
{
    public int Id { get; set; }

    public int? TypeRoomId { get; set; }

    public int? HotelId { get; set; }

    public string? State { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Hotel? Hotel { get; set; }

    public virtual ICollection<SmokeSensor> SmokeSensors { get; set; } = new List<SmokeSensor>();

    public virtual ICollection<Thermostat> Thermostats { get; set; } = new List<Thermostat>();

    public virtual TypeRoom? TypeRoom { get; set; }
}
