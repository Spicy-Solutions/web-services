using System;
using System.Collections.Generic;

namespace SweetManagerWebService.Models;

public partial class Notification
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? SenderType { get; set; }

    public int? SenderId { get; set; }

    public int? ReceiverId { get; set; }

    public int? HotelId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Hotel? Hotel { get; set; }
}
