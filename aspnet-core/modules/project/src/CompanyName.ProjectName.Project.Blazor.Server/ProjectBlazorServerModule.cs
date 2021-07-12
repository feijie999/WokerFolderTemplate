using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace CompanyName.ProjectName.Project.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(ProjectBlazorModule)
        )]
    public class ProjectBlazorServerModule : AbpModule
    {
        
    }
}