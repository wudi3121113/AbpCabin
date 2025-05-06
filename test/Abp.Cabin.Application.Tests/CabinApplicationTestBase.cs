using Volo.Abp.Modularity;

namespace Abp.Cabin;

public abstract class CabinApplicationTestBase<TStartupModule> : CabinTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
