using CompanyName.ProjectName.Project.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CompanyName.ProjectName.Project
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ProjectEntityFrameworkCoreTestModule)
        )]
    public class ProjectDomainTestModule : AbpModule
    {
        
    }
}
