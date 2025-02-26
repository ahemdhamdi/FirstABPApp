using Volo.Abp.Modularity;

namespace firstAbp;

[DependsOn(
    typeof(firstAbpApplicationModule),
    typeof(firstAbpDomainTestModule)
)]
public class firstAbpApplicationTestModule : AbpModule
{

}
