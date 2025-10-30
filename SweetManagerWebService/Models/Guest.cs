using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Guest
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? State { get; set; }

    public int? RoleId { get; set; }

    public string? PhotoUrl { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual GuestCredential? GuestCredential { get; set; }

    public virtual ICollection<GuestPreference> GuestPreferences { get; set; } = new List<GuestPreference>();

    public virtual ICollection<PaymentCustomer> PaymentCustomers { get; set; } = new List<PaymentCustomer>();

    public virtual Role? Role { get; set; }
}
