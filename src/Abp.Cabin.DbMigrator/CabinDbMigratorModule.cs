using Abp.Cabin.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Abp.Cabin.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CabinEntityFrameworkCoreModule),
    typeof(CabinApplicationContractsModule)
)]
public class CabinDbMigratorModule : AbpModule
{
}
