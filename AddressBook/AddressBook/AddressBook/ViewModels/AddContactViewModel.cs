using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AddressBook.Models;
using AddressBook.Services.Contacts;
using Xamarin.Forms;

namespace AddressBook.ViewModels
{
    public class AddContactViewModel:BaseViewModel
    {
        private readonly IContactService _service;

        public AddContactViewModel()
        {
            _service=new ContactService();
            this.AddContactCommand=new Command<string>((key) =>
            {
                //_service.Add(new Contacts()
                //{
                //    Name = nameEntry.Text,
                //    Mobile = mobileEntry.Text,
                //    Work = workEntry.Text,
                //    Main = mainEntry.Text
                //});
                //await Navigation.PopAsync();
            });
            
        }

        public ICommand AddContactCommand { get; private set; }
    }
}
