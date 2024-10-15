using AbpSolution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpSolution.Permissions;

public class AbpSolutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(AbpSolutionPermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = bookStoreGroup.AddPermission(AbpSolutionPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AbpSolutionPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AbpSolutionPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AbpSolutionPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = bookStoreGroup.AddPermission(AbpSolutionPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(AbpSolutionPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(AbpSolutionPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(AbpSolutionPermissions.Authors.Delete, L("Permission:Authors.Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpSolutionResource>(name);
    }
}
