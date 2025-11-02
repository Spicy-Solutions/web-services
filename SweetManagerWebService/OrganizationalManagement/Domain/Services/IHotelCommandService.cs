
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Aggregates;
using SweetManagerWebService.OrganizationalManagement.Domain.Models.Commands;

namespace SweetManagerWebService.OrganizationalManagement.Domain.Services;

public interface IHotelCommandService
{
    Task<Hotel?> Handle(CreateHotelCommand command);
    Task<Hotel?> Handle(UpdateHotelCommand command);
}