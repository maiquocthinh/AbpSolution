using AbpSolution.Samples;
using Xunit;

namespace AbpSolution.EntityFrameworkCore.Domains;

[Collection(AbpSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpSolutionEntityFrameworkCoreTestModule>
{

}
