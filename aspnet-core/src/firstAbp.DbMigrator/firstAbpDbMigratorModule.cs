using firstAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace firstAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(firstAbpEntityFrameworkCoreModule),
    typeof(firstAbpApplicationContractsModule)
    )]
public class firstAbpDbMigratorModule : AbpModule
{
}
