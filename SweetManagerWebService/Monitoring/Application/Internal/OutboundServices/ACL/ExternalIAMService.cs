using SweetManagerWebService.IAM.Interfaces.ACL;
using SweetManagerWebService.Monitoring.Domain.Model.ValueObjects;

namespace SweetManagerWebService.Monitoring.Application.Internal.OutboundServices.ACL;

public class ExternalIAMService(IIamContextFacade iamContextFacade)
{
    public async Task<Temperature?> FetchGuestPreferenceById(int id)
    {
        try
        {
            var guestPreference = await iamContextFacade.FetchGuestPreferenceById(id);

            if (guestPreference is null) return await Task.FromResult<Temperature?>(null);

            return new Temperature(guestPreference.Temperature);
        }
        catch (Exception)
        {
            return null;
        }
    }
}