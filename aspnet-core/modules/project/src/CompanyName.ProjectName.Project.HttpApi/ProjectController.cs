using CompanyName.ProjectName.Project.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CompanyName.ProjectName.Project
{
    public abstract class ProjectController : AbpController
    {
        protected ProjectController()
        {
            LocalizationResource = typeof(ProjectResource);
        }
    }
}
