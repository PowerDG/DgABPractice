using Volo.Abp.Settings;

namespace DGCorERM.MVC.Settings
{
    public class MVCSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MVCSettings.MySetting1));
        }
    }
}
