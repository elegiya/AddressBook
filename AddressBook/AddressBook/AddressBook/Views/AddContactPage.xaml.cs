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
    public partial class AddContactPage : ContentPage
    {
        private readonly IContactService _service;

        public AddContactPage()
        {
            InitializeComponent();
            _service = new ContactService();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            addContactButton.Clicked += OnAddButtonClicked;
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            _service.Add(new Contacts()
            {
                Name = nameEntry.Text,
                Mobile = mobileEntry.Text,
                Work = workEntry.Text,
                Main = mainEntry.Text
            });
            await Navigation.PopAsync();
        }
    }
}