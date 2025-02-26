using Volo.Abp.Settings;

namespace firstAbp.Settings;

public class firstAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(firstAbpSettings.MySetting1));
    }
}
