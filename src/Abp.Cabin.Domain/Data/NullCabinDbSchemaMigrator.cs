using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Cabin.Data;

/* This is used if database provider does't define
 * ICabinDbSchemaMigrator implementation.
 */
public class NullCabinDbSchemaMigrator : ICabinDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
