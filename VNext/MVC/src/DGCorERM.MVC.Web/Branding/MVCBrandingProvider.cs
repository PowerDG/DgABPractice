using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace DGCorERM.MVC.Branding
{
    [Dependency(ReplaceServices = true)]
    public class MVCBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MVC";
    }
}
