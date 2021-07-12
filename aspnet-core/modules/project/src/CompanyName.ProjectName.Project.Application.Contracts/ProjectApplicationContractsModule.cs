using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace CompanyName.ProjectName.Project
{
    [DependsOn(
        typeof(ProjectDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ProjectApplicationContractsModule : AbpModule
    {

    }
}
