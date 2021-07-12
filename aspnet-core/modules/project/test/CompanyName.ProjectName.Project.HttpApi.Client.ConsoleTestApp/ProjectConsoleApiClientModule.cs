using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CompanyName.ProjectName.Project
{
    [DependsOn(
        typeof(ProjectHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ProjectConsoleApiClientModule : AbpModule
    {
        
    }
}
