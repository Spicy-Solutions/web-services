using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Commands.Authentication;

namespace SweetManagerWebService.IAM.Domain.Services.CommandServices.Users
{
    public interface IOwnerCommandService
    {
        Task<Owner?> Handle(SignUpUserCommand command);

        Task<Owner?> Handle(UpdateUserCommand command);

        Task<dynamic?> Handle(SignInUserCommand command);
    }
}