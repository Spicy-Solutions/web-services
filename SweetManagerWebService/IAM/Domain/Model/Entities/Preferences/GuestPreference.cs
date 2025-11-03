using System;
using System.Collections.Generic;
using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Commands.Preferences;

namespace SweetManagerWebService.IAM.Domain.Model.Entities.Preferences;

public partial class GuestPreference
{
    public int Id { get; set; }

    public int? GuestId { get; set; }

    public int Temperature { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Guest? Guest { get; set; }

    public GuestPreference() { }

    public void Update(UpdateGuestPreferenceCommand command)
    {
        GuestId = command.GuestId;
        Temperature = command.Temperature;
    }

    public GuestPreference(CreateGuestPreferenceCommand command)
    {
        GuestId = command.GuestId;
        Temperature = command.Temperature;
    }
}