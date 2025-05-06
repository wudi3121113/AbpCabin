using Abp.Cabin.Samples;
using Xunit;

namespace Abp.Cabin.EntityFrameworkCore.Domains;

[Collection(CabinTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CabinEntityFrameworkCoreTestModule>
{

}
