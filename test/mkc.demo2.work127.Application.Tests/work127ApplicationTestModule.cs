using Volo.Abp.Modularity;

namespace mkc.demo2.work127
{
    [DependsOn(
        typeof(work127ApplicationModule),
        typeof(work127DomainTestModule)
        )]
    public class work127ApplicationTestModule : AbpModule
    {

    }
}