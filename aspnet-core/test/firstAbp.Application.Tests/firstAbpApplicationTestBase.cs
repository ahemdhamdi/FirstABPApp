using Volo.Abp.Modularity;

namespace firstAbp;

public abstract class firstAbpApplicationTestBase<TStartupModule> : firstAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
