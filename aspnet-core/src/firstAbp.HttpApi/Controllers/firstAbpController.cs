using firstAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace firstAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class firstAbpController : AbpControllerBase
{
    protected firstAbpController()
    {
        LocalizationResource = typeof(firstAbpResource);
    }
}
