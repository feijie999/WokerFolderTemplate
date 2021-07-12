using Volo.Abp.Modularity;

namespace CompanyName.ProjectName.Project
{
    [DependsOn(
        typeof(ProjectApplicationModule),
        typeof(ProjectDomainTestModule)
        )]
    public class ProjectApplicationTestModule : AbpModule
    {

    }
}
