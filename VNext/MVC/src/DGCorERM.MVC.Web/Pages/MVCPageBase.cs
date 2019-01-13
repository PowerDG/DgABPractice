using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using DGCorERM.MVC.Localization.MVC;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DGCorERM.MVC.Pages
{
    public abstract class MVCPageBase : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<MVCResource> L { get; set; }
    }
}
