using AbpSolution.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AbpSolution.EntityFrameworkCore.Applications.Books
{
    [Collection(AbpSolutionTestConsts.CollectionDefinitionName)]
    public class EfCoreBookAppService_Tests : BookAppService_Tests<AbpSolutionEntityFrameworkCoreTestModule>
    {

    }
}
