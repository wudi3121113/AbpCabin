using Volo.Abp.Modularity;

namespace Abp.Cabin;

/* Inherit from this class for your domain layer tests. */
public abstract class CabinDomainTestBase<TStartupModule> : CabinTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
