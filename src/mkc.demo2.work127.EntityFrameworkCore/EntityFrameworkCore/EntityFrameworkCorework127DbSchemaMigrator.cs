using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using mkc.demo2.work127.Data;
using Volo.Abp.DependencyInjection;

namespace mkc.demo2.work127.EntityFrameworkCore
{
    public class EntityFrameworkCorework127DbSchemaMigrator
        : Iwork127DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorework127DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the work127DbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<work127DbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
