using Volo.Abp.Settings;

namespace Abp.Cabin.Settings;

public class CabinSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CabinSettings.MySetting1));
    }
}
