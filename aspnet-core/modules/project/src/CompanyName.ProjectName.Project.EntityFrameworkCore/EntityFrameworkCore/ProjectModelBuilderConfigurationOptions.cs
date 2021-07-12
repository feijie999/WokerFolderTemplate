using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CompanyName.ProjectName.Project.EntityFrameworkCore
{
    public class ProjectModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ProjectModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}