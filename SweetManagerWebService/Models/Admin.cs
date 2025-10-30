using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? State { get; set; }

    public int? RoleId { get; set; }

    public int? HotelId { get; set; }

    public string? PhotoUrl { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual AdminCredential? AdminCredential { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual Role? Role { get; set; }
}
