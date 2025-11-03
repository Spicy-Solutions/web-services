namespace SweetManagerWebService.OrganizationalManagement.Interfaces.ACL;

public interface IOrganizationManagementContextFacade
{
    Task<int> FetchOwnerIdByHotelId(int hotelId);
}