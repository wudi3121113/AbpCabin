using Volo.Abp.Modularity;

namespace Abp.Cabin;

[DependsOn(
    typeof(CabinDomainModule),
    typeof(CabinTestBaseModule)
)]
public class CabinDomainTestModule : AbpModule
{

}
