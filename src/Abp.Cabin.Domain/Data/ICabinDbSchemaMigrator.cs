using System.Threading.Tasks;

namespace Abp.Cabin.Data;

public interface ICabinDbSchemaMigrator
{
    Task MigrateAsync();
}
