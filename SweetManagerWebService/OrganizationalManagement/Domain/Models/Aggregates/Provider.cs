using SweetManagerWebService.Models;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.ValueObjects;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
public partial class Provider
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public State? State { get; set; }

    public int HotelId { get; set; }

    public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();

    public virtual Hotel Hotel { get; set; } = null!;

    public Provider() {}

    public Provider(string name, string email, string phone, string state, int hotelId)
    {
        Name = name;
        Email = email;
        Phone = phone;
        State = Enum.TryParse<State>(state, true, out var stateEnum) ? stateEnum : throw new ArgumentException("Invalid state, use 'Active' or 'Inactive'");
        HotelId = hotelId;
    }

    public Provider(CreateProviderCommand command)
    {
        Name = command.Name;
        Email = command.Email;
        Phone = command.Phone;
        State = Enum.TryParse<State>(command.State, true, out var stateEnum) ? stateEnum : throw new ArgumentException("Invalid state, use 'Active' or 'Inactive'");
        HotelId = command.HotelId; 
    }
    public void UpdateData(UpdateProviderCommand command)
    {
        Name = command.Name;
        Email = command.Email;
        Phone = command.Phone;
    }
    
    public void UpdateState(string state)
    {
        State = Enum.TryParse<State>(state, true, out var stateEnum) ? stateEnum : throw new ArgumentException("Invalid state, use 'Active' or 'Inactive'");
    }

    public void DisableProvider()
    {
        State = ValueObjects.State.Inactive;
    }
    
    public bool IsActive()
    {
        return State == ValueObjects.State.Active;
    }
}