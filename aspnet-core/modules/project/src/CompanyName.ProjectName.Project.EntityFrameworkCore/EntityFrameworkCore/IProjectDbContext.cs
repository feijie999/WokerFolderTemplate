using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CompanyName.ProjectName.Project.EntityFrameworkCore
{
    [ConnectionStringName(ProjectDbProperties.ConnectionStringName)]
    public interface IProjectDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}