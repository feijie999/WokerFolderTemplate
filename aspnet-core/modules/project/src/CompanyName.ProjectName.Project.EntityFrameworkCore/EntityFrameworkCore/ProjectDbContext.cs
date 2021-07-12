using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CompanyName.ProjectName.Project.EntityFrameworkCore
{
    [ConnectionStringName(ProjectDbProperties.ConnectionStringName)]
    public class ProjectDbContext : AbpDbContext<ProjectDbContext>, IProjectDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureProject();
        }
    }
}