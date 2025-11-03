using SweetManagerWebService.IAM.Domain.Model.Aggregates;

namespace SweetManagerWebService.Communication.Domain.Model.ValueObjects
{
    public record RecoveredAdmin(string Name, string FullName, string Email, string Phone);
}
