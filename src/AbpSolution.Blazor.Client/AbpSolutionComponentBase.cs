using AbpSolution.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpSolution.Blazor.Client;

public abstract class AbpSolutionComponentBase : AbpComponentBase
{
    protected AbpSolutionComponentBase()
    {
        LocalizationResource = typeof(AbpSolutionResource);
    }
}
