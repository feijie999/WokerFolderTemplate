using CompanyName.ProjectName.Project.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CompanyName.ProjectName.Project.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ProjectPageModel : AbpPageModel
    {
        protected ProjectPageModel()
        {
            LocalizationResourceType = typeof(ProjectResource);
            ObjectMapperContext = typeof(ProjectWebModule);
        }
    }
}