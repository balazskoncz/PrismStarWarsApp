// <copyright file="MainPageViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PrismStarWarsApp.ViewModels
{
    using System.Windows.Input;
    using Prism.Commands;
    using Prism.Mvvm;
    using Prism.Navigation;
    using PrismStarWarsApp.Helpers.Version;

    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService navigationService;

        private IApplicationVersionHelper applicationVersionHelper;

        private string version;

        public MainPageViewModel(
                                 INavigationService navigationService,
                                 IApplicationVersionHelper applicationVersionHelper)
        {
            this.navigationService = navigationService;
            this.applicationVersionHelper = applicationVersionHelper;

            this.Version = this.applicationVersionHelper.GetApplicationVersion();

            this.PlanetsCommand = new DelegateCommand(this.ExecutePlanetsCommand);
            this.StarShipsCommand = new DelegateCommand(this.ExecuteStarShipsCommand);
            this.PeopleCommand = new DelegateCommand(this.ExecutePeopleCommand);
        }

        public string Version
        {
            get { return this.version; }
            set { this.SetProperty(ref this.version, value); }
        }

        public ICommand PlanetsCommand { get; set; }

        public ICommand StarShipsCommand { get; set; }

        public ICommand PeopleCommand { get; set; }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        private void ExecutePeopleCommand()
        {
            this.navigationService.NavigateAsync("PeoplePage");
        }

        private void ExecuteStarShipsCommand()
        {
        }

        private void ExecutePlanetsCommand()
        {
        }
    }
}
