using Xunit;

namespace Abp.Cabin.EntityFrameworkCore;

[CollectionDefinition(CabinTestConsts.CollectionDefinitionName)]
public class CabinEntityFrameworkCoreCollection : ICollectionFixture<CabinEntityFrameworkCoreFixture>
{

}
