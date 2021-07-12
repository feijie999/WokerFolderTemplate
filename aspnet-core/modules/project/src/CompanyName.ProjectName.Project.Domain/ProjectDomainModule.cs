using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace CompanyName.ProjectName.Project
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ProjectDomainSharedModule)
    )]
    public class ProjectDomainModule : AbpModule
    {

    }
}
