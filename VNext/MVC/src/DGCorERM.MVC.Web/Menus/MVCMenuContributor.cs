using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using DGCorERM.MVC.Localization.MVC;
using Volo.Abp.UI.Navigation;

namespace DGCorERM.MVC.Menus
{
    public class MVCMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<MVCResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("MVC.Home", l["Menu:Home"], "/"));
        }
    }
}
