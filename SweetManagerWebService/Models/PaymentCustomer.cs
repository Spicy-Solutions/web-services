using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class PaymentCustomer
{
    public int Id { get; set; }

    public int? GuestId { get; set; }

    public decimal? FinalAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Guest? Guest { get; set; }
}
