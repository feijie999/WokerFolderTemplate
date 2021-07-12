﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace CompanyName.ProjectName.Project.MongoDB
{
    [DependsOn(
        typeof(ProjectDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class ProjectMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<ProjectMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
