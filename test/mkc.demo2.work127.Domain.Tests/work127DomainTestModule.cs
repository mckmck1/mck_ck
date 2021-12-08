using mkc.demo2.work127.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace mkc.demo2.work127
{
    [DependsOn(
        typeof(work127EntityFrameworkCoreTestModule)
        )]
    public class work127DomainTestModule : AbpModule
    {

    }
}