using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace mkc.demo2.work127.Data
{
    /* This is used if database provider does't define
     * Iwork127DbSchemaMigrator implementation.
     */
    public class Nullwork127DbSchemaMigrator : Iwork127DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}