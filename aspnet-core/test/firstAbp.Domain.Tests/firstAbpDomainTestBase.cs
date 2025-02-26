using Volo.Abp.Modularity;

namespace firstAbp;

/* Inherit from this class for your domain layer tests. */
public abstract class firstAbpDomainTestBase<TStartupModule> : firstAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
