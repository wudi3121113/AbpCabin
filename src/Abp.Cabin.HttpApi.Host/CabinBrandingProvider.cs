using Microsoft.Extensions.Localization;
using Abp.Cabin.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.Cabin;

[Dependency(ReplaceServices = true)]
public class CabinBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CabinResource> _localizer;

    public CabinBrandingProvider(IStringLocalizer<CabinResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
