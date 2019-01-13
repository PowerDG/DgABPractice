using DGCorERM.MVC.Localization.MVC;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DGCorERM.MVC.Pages
{
    public abstract class MVCPageModelBase : AbpPageModel
    {
        protected MVCPageModelBase()
        {
            LocalizationResourceType = typeof(MVCResource);
        }
    }
}