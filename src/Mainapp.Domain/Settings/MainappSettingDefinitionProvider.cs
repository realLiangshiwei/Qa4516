using Volo.Abp.Settings;

namespace Mainapp.Settings;

public class MainappSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MainappSettings.MySetting1));
    }
}
