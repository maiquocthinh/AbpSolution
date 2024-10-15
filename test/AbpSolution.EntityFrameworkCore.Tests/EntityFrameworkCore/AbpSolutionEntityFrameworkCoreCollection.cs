using Xunit;

namespace AbpSolution.EntityFrameworkCore;

[CollectionDefinition(AbpSolutionTestConsts.CollectionDefinitionName)]
public class AbpSolutionEntityFrameworkCoreCollection : ICollectionFixture<AbpSolutionEntityFrameworkCoreFixture>
{

}
