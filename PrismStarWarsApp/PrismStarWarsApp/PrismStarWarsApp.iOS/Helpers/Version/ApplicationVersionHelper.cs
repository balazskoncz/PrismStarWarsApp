// <copyright file="ApplicationVersionHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

[assembly: Xamarin.Forms.Dependency(typeof(PrismStarWarsApp.iOS.Helpers.Version.ApplicationVersionHelper))]
namespace PrismStarWarsApp.iOS.Helpers.Version
{
    using Foundation;
    using PrismStarWarsApp.Helpers.Version;

    public class ApplicationVersionHelper : IApplicationVersionHelper
    {
        private const string VersionKey = "CFBundleShortVersionString";

        public string GetApplicationVersion()
        {
            NSObject version = NSBundle.MainBundle.InfoDictionary[VersionKey];

            return version.ToString();
        }
    }
}