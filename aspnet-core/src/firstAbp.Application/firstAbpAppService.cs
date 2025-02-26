using System;
using System.Collections.Generic;
using System.Text;
using firstAbp.Localization;
using Volo.Abp.Application.Services;

namespace firstAbp;

/* Inherit your application services from this class.
 */
public abstract class firstAbpAppService : ApplicationService
{
    protected firstAbpAppService()
    {
        LocalizationResource = typeof(firstAbpResource);
    }
}
