// <copyright file="ApplicationVersionHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

[assembly: Xamarin.Forms.Dependency(typeof(PrismStarWarsApp.Droid.Helpers.Version.ApplicationVersionHelper))]
namespace PrismStarWarsApp.Droid.Helpers.Version
{
    using Android.Content;
    using PrismStarWarsApp.Helpers.Version;

    public class ApplicationVersionHelper : IApplicationVersionHelper
    {
        public string GetApplicationVersion()
        {
            Context context = Android.App.Application.Context;
            var versionInfo = context.PackageManager.GetPackageInfo(context.PackageName, 0);

            return versionInfo.VersionName;
        }
    }
}