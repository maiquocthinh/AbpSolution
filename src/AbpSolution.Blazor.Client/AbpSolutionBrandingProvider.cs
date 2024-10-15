using Microsoft.Extensions.Localization;
using AbpSolution.Localization;
using Microsoft.Extensions.Localization;
using AbpSolution.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpSolution.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class AbpSolutionBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpSolutionResource> _localizer;

    public AbpSolutionBrandingProvider(IStringLocalizer<AbpSolutionResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
