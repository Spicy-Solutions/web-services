namespace SweetManagerWebService.IAM.Interfaces.REST.Resources.Preferences
{
    public record GuestPreferenceResource(int Id, int? GuestId, int? Temperature);
}