using CompanyName.ProjectName.Project.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CompanyName.ProjectName.Project.Permissions
{
    public class ProjectPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ProjectPermissions.GroupName, L("Permission:Project"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProjectResource>(name);
        }
    }
}