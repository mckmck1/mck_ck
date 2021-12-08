using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace mkc.demo2.work127
{
    [Dependency(ReplaceServices = true)]
    public class work127BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "work127";
    }
}
