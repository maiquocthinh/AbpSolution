using AbpSolution.Samples;
using Xunit;

namespace AbpSolution.EntityFrameworkCore.Applications;

[Collection(AbpSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpSolutionEntityFrameworkCoreTestModule>
{

}
