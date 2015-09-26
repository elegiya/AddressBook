using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Models;
using AddressBook.Services.Contacts;
using Xamarin.Forms;

namespace AddressBook.Views
{
    public partial class AllContactsPage : ContentPage
    {
        private readonly IContactService _contactService;

        public AllContactsPage()
        {
            InitializeComponent();
            _contactService = new ContactService();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var items = _contactService.GetAllNames();
            contactList.ItemsSource = items;
            contactItem.Clicked += OnContactItemClick;
            if (items.Count() == 0)
            {
                var result = DisplayAlert("Contact records",
                    "You do not have any contact. Do you want to add a new one?",
                    "No", "Yes");
            }
        }

        private async void OnContactItemClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailedInfoPage());
        }
    }
}
