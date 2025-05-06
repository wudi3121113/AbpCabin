using Volo.Abp.Modularity;

namespace Abp.Cabin;

[DependsOn(
    typeof(CabinApplicationModule),
    typeof(CabinDomainTestModule)
)]
public class CabinApplicationTestModule : AbpModule
{

}
