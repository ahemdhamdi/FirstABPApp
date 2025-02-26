using System.Threading.Tasks;

namespace firstAbp.Data;

public interface IfirstAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
