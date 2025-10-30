using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<Guest> Guests { get; set; } = new List<Guest>();

    public virtual ICollection<Owner> Owners { get; set; } = new List<Owner>();
}
