using firstAbp.Samples;
using Xunit;

namespace firstAbp.EntityFrameworkCore.Domains;

[Collection(firstAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<firstAbpEntityFrameworkCoreTestModule>
{

}
