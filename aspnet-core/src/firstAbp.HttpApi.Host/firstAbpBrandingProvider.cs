using Microsoft.Extensions.Localization;
using firstAbp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace firstAbp;

[Dependency(ReplaceServices = true)]
public class firstAbpBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<firstAbpResource> _localizer;

    public firstAbpBrandingProvider(IStringLocalizer<firstAbpResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
