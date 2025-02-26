using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using firstAbp.Data;
using Volo.Abp.DependencyInjection;

namespace firstAbp.EntityFrameworkCore;

public class EntityFrameworkCorefirstAbpDbSchemaMigrator
    : IfirstAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorefirstAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the firstAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<firstAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
