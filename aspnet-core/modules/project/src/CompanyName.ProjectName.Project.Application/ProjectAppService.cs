using CompanyName.ProjectName.Project.Localization;
using Volo.Abp.Application.Services;

namespace CompanyName.ProjectName.Project
{
    public abstract class ProjectAppService : ApplicationService
    {
        protected ProjectAppService()
        {
            LocalizationResource = typeof(ProjectResource);
            ObjectMapperContext = typeof(ProjectApplicationModule);
        }
    }
}
