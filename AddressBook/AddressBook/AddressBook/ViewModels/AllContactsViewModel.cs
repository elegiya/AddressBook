using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AddressBook.Models;
using AddressBook.Services.Contacts;
using Xamarin.Forms;

namespace AddressBook.ViewModels
{
    public class AllContactsViewModel: BaseViewModel
    {
        private readonly IContactService _contactService;

        public AllContactsViewModel()
        {
            _contactService=new ContactService();
            this.GetAllContactsCommand = new Command<string>((nothing) =>
            {
                
            });
        }

        

        public ICommand GetAllContactsCommand { get; private set; }
    }
}
