using mkc.demo2.work127.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace mkc.demo2.work127.Permissions
{
    public class work127PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(work127Permissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(work127Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<work127Resource>(name);
        }
    }
}
