using Xunit;

namespace firstAbp.EntityFrameworkCore;

[CollectionDefinition(firstAbpTestConsts.CollectionDefinitionName)]
public class firstAbpEntityFrameworkCoreCollection : ICollectionFixture<firstAbpEntityFrameworkCoreFixture>
{

}
