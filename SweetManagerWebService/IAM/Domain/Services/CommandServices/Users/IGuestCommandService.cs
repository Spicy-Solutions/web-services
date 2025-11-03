using SweetManagerWebService.IAM.Domain.Model.Aggregates;
using SweetManagerWebService.IAM.Domain.Model.Commands.Authentication;

namespace SweetManagerWebService.IAM.Domain.Services.CommandServices.Users
{
    public interface IGuestCommandService
    {
        Task<Guest?> Handle(SignUpUserCommand command);

        Task<Guest?> Handle(UpdateUserCommand command);

        Task<dynamic?> Handle(SignInUserCommand command);
    }
}