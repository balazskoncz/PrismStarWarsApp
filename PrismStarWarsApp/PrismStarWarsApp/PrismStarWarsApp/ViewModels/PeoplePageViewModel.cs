// <copyright file="PeoplePageViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PrismStarWarsApp.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Prism.Commands;
    using Prism.Mvvm;
    using Prism.Navigation;

    public class PeoplePageViewModel : BindableBase, INavigationAware
    {
        private INavigationService navigationService;

        public PeoplePageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            this.People = new ObservableCollection<string> { "Luke", "Han", "Jabba" };

            this.ItemTappedCommand = new DelegateCommand<string>(this.ExecuteItemTappedCommand);
        }

        public ObservableCollection<string> People { get; set; }

        public ICommand ItemTappedCommand { get; set; }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        private void ExecuteItemTappedCommand(string obj)
        {
            NavigationParameters parameters = new NavigationParameters();
            parameters.Add("name", obj);

            this.navigationService.NavigateAsync("PersonPage", parameters);
        }
    }
}
