// <copyright file="PersonPageViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PrismStarWarsApp.ViewModels
{
    using Prism.Mvvm;
    using Prism.Navigation;

    public class PersonPageViewModel : BindableBase, INavigationAware
    {
        private string name;

        public PersonPageViewModel()
        {
        }

        public string Name
        {
            get { return this.name; }
            set { this.SetProperty(ref this.name, value); }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            this.Name = parameters["name"].ToString();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
