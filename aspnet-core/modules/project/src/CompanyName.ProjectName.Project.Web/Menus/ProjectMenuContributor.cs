using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace CompanyName.ProjectName.Project.Web.Menus
{
    public class ProjectMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(ProjectMenus.Prefix, displayName: "Project", "~/Project", icon: "fa fa-globe"));

            return Task.CompletedTask;
        }
    }
}