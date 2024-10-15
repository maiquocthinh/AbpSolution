using Volo.Abp.Modularity;

namespace AbpSolution;

[DependsOn(
    typeof(AbpSolutionDomainModule),
    typeof(AbpSolutionTestBaseModule)
)]
public class AbpSolutionDomainTestModule : AbpModule
{

}
