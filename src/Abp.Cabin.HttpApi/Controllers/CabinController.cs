using Abp.Cabin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Cabin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CabinController : AbpControllerBase
{
    protected CabinController()
    {
        LocalizationResource = typeof(CabinResource);
    }
}
