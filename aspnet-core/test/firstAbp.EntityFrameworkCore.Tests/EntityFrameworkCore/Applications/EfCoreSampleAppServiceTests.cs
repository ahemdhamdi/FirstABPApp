using firstAbp.Samples;
using Xunit;

namespace firstAbp.EntityFrameworkCore.Applications;

[Collection(firstAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<firstAbpEntityFrameworkCoreTestModule>
{

}
