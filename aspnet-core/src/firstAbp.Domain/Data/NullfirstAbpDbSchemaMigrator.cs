using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace firstAbp.Data;

/* This is used if database provider does't define
 * IfirstAbpDbSchemaMigrator implementation.
 */
public class NullfirstAbpDbSchemaMigrator : IfirstAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
