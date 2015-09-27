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
    public class DetailedContactViewModel:BaseViewModel
    {
        private readonly IContactService _service;
        private Contacts _contactsModel;

        public DetailedContactViewModel()
        {
            _service=new ContactService();
            _contactsModel=new Contacts();

            this.DisplayContactInfoCommand=new Command<int>((key) =>
            {
                _contactsModel = _service.GetById(key);
                Name = _contactsModel?.Name;
                Mobile = _contactsModel?.Mobile;
                Work = _contactsModel?.Work;
                Main = _contactsModel?.Main;
            });
        }
        
        public ICommand DisplayContactInfoCommand { get; private set; }

        public string Name
        {
            get { return _contactsModel.Name; }
            set
            {
                if (_contactsModel.Name != value)
                {
                    _contactsModel.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Mobile
        {
            get { return _contactsModel.Mobile; }
            set
            {
                if (_contactsModel.Mobile != value)
                {
                    _contactsModel.Mobile = value;
                    OnPropertyChanged("Mobile");
                }
            }
        }

        public string Work {
            get { return _contactsModel.Work; }
            set
            {
                if (_contactsModel.Work != value)
                {
                    _contactsModel.Work = value;
                    OnPropertyChanged("Work");
                }
            }
        }

        public string Main {
            get { return _contactsModel.Main; }
            set
            {
                if (_contactsModel.Main != value)
                {
                    _contactsModel.Main = value;
                    OnPropertyChanged("Main");
                }
            }
        }
    }
}
