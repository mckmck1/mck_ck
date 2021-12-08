using mkc.demo2.work127.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace mkc.demo2.work127.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class work127Controller : AbpController
    {
        protected work127Controller()
        {
            LocalizationResource = typeof(work127Resource);
        }
    }
}