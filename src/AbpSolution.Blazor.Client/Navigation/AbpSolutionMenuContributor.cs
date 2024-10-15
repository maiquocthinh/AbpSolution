﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AbpSolution.Localization;
using AbpSolution.Permissions;
using AbpSolution.MultiTenancy;
using Volo.Abp.Account.Localization;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.Users;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.Identity.Blazor;

namespace AbpSolution.Blazor.Client.Navigation;

public class AbpSolutionMenuContributor : IMenuContributor
{
    private readonly IConfiguration _configuration;

    public AbpSolutionMenuContributor(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
        else if (context.Menu.Name == StandardMenus.User)
        {
            await ConfigureUserMenuAsync(context);
        }
    }

    private static async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<AbpSolutionResource>();

        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 5;

        context.Menu.AddItem(new ApplicationMenuItem(
            AbpSolutionMenus.Home,
            l["Menu:Home"],
            "/",
            icon: "fas fa-home",
            order: 1
        ));

        var bookStoreMenu = new ApplicationMenuItem(
                "AbpSolution",
                l["Menu:BookStore"],
                icon: "fa fa-book"
            );

        context.Menu.AddItem(bookStoreMenu);

        //CHECK the PERMISSION
        if (await context.IsGrantedAsync(AbpSolutionPermissions.Books.Default))
        {
            bookStoreMenu.AddItem(new ApplicationMenuItem(
                "AbpSolution.Books",
                l["Menu:Books"],
                url: "/books"
            ));
        }

        if (await context.IsGrantedAsync(AbpSolutionPermissions.Authors.Default))
        {
            bookStoreMenu.AddItem(new ApplicationMenuItem(
                "AbpSolution.Authors",
                l["Menu:Authors"],
                url: "/authors"
            ));
        }

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);
    }

    private async Task ConfigureUserMenuAsync(MenuConfigurationContext context)
    {
        var accountStringLocalizer = context.GetLocalizer<AccountResource>();
        var authServerUrl = _configuration["AuthServer:Authority"] ?? "";

        context.Menu.AddItem(new ApplicationMenuItem(
            "Account.Manage",
            accountStringLocalizer["MyAccount"],
            $"{authServerUrl.EnsureEndsWith('/')}Account/Manage",
            icon: "fa fa-cog",
            order: 1000,
            target: "_blank").RequireAuthenticated());

        await Task.CompletedTask;
    }
}