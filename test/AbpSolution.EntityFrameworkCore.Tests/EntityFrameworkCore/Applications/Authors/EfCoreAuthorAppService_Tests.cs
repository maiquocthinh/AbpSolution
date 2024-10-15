using AbpSolution.Authors;
using Xunit;

namespace AbpSolution.EntityFrameworkCore.Applications.Authors
{
    [Collection(AbpSolutionTestConsts.CollectionDefinitionName)]
    public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<AbpSolutionEntityFrameworkCoreTestModule>
    {

    }
}
