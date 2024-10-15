using Volo.Abp.Modularity;

namespace AbpSolution;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpSolutionDomainTestBase<TStartupModule> : AbpSolutionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
