using System;
using System.Collections.Generic;
using System.Text;
using mkc.demo2.work127.Localization;
using Volo.Abp.Application.Services;

namespace mkc.demo2.work127
{
    /* Inherit your application services from this class.
     */
    public abstract class work127AppService : ApplicationService
    {
        protected work127AppService()
        {
            LocalizationResource = typeof(work127Resource);
        }
    }
}
