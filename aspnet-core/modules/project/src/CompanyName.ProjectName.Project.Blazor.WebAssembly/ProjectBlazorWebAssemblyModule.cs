using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace CompanyName.ProjectName.Project.Blazor.WebAssembly
{
    [DependsOn(
        typeof(ProjectBlazorModule),
        typeof(ProjectHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class ProjectBlazorWebAssemblyModule : AbpModule
    {
        
    }
}