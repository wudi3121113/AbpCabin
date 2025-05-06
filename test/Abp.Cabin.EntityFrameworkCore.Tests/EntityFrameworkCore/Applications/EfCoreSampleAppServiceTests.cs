using Abp.Cabin.Samples;
using Xunit;

namespace Abp.Cabin.EntityFrameworkCore.Applications;

[Collection(CabinTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CabinEntityFrameworkCoreTestModule>
{

}
