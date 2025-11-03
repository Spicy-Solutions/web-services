namespace SweetManagerWebService.IAM.Domain.Model.Commands.Preferences
{
    public record UpdateGuestPreferenceCommand(int Id,int GuestId, int Temperature);

}