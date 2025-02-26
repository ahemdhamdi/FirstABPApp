using Volo.Abp.Modularity;

namespace firstAbp;

[DependsOn(
    typeof(firstAbpDomainModule),
    typeof(firstAbpTestBaseModule)
)]
public class firstAbpDomainTestModule : AbpModule
{

}
