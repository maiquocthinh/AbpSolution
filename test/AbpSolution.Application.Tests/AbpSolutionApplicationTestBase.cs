using Volo.Abp.Modularity;

namespace AbpSolution;

public abstract class AbpSolutionApplicationTestBase<TStartupModule> : AbpSolutionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
