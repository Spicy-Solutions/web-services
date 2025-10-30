using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Hotel
{
    public int Id { get; set; }

    public int OwnerId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Category { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<Multimedia> Multimedia { get; set; } = new List<Multimedia>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual Owner Owner { get; set; } = null!;

    public virtual ICollection<Provider> Providers { get; set; } = new List<Provider>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();
}
