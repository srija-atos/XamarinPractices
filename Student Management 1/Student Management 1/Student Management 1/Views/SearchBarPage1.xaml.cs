using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Student_Management_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage1 : ContentPage
    {
      


        public SearchBarPage1()
        {
            InitializeComponent();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            // Retrieve all the notes from the database, and set them as the
            // data source for the CollectionView.
            list.ItemsSource = await PersonOperations.GetPersonAsync();
        }



        private async void Search()
        {
            try
            {
                list.BeginRefresh(); if (string.IsNullOrEmpty(searchBar.Text))
                    list.ItemsSource = await PersonOperations.GetPersonAsync();
                else
                {
                    List<Person> employees = await PersonOperations.GetPersonAsync();
                    list.ItemsSource = employees.Where(x => x.FirstName.ToLower().StartsWith(searchBar.Text.ToLower()));
                }
                list.EndRefresh();
            }
            catch (Exception )
            {
               //DisplayAlert("Error", ex.Message, "OK");
            }
        }
        void OnSearchBarButtonPressed(object sender, EventArgs args)
        {
            Search();
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Search();
        }
        private async void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            {
                Person person = e.Item as Person;
                if (person != null)
                    await Navigation.PushAsync(new AddViewPage(person,false));
               
            }
           


        }
        private async void MenuItemDelete(object sender, EventArgs e)
        {
            try
            {
                if (await DisplayAlert("Note", "Are you sure to delete?", "Yes", "No"))
                {
                    MenuItem grid = (MenuItem)sender;
                    if (grid != null)
                    {
                        Person person = (Person)grid.BindingContext;
                        if (person != null)
                        {
                            await PersonOperations.DeletePersonAsync(person);
                            list.ItemsSource=await PersonOperations.GetPersonAsync();
                           

                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private async void MenuItemEdit(object sender, EventArgs e)
        {
            MenuItem grid = (MenuItem)sender;
            if (grid != null)
            {
                Person person = (Person)grid.BindingContext;
                if (person != null)
                {
                    await Navigation.PushAsync(new AddViewPage(person));
                }
            }
        }
        private async void btnAddNote_Clicked(object sender,EventArgs e)
        {
            
              await Navigation.PushAsync(new AddViewPage(null));

        }

    }
}

