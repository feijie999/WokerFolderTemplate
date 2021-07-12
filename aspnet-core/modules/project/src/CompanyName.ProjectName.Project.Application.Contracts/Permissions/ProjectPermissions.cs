using Volo.Abp.Reflection;

namespace CompanyName.ProjectName.Project.Permissions
{
    public class ProjectPermissions
    {
        public const string GroupName = "Project";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProjectPermissions));
        }
    }
}