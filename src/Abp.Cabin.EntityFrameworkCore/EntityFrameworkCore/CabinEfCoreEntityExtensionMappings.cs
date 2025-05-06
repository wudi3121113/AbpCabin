using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace Abp.Cabin.EntityFrameworkCore;

public static class CabinEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        CabinGlobalFeatureConfigurator.Configure();
        CabinModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
            ObjectExtensionManager.Instance
                        .MapEfCoreProperty<IdentityUser, string>(
                            "SiteCode",
                            (entityBuilder, propertyBuilder) =>
                            {
                                propertyBuilder.HasMaxLength(128);
                            }
                        );
        });
    }
}
