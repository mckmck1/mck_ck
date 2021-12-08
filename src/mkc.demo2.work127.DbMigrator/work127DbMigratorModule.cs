using mkc.demo2.work127.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace mkc.demo2.work127.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(work127EntityFrameworkCoreModule),
        typeof(work127ApplicationContractsModule)
        )]
    public class work127DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
