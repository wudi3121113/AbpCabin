using Abp.Cabin.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Cabin;

/* Inherit your application services from this class.
 */
public abstract class CabinAppService : ApplicationService
{
    protected CabinAppService()
    {
        LocalizationResource = typeof(CabinResource);
    }
}
