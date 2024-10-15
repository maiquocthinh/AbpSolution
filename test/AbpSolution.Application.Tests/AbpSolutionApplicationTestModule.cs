using Volo.Abp.Modularity;

namespace AbpSolution;

[DependsOn(
    typeof(AbpSolutionApplicationModule),
    typeof(AbpSolutionDomainTestModule)
)]
public class AbpSolutionApplicationTestModule : AbpModule
{

}
