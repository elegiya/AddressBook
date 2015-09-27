using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Services.Contacts;
using Xamarin.Forms;

namespace AddressBook.Views
{
    public partial class DetailedInfoPage : ContentPage
    {
        public DetailedInfoPage()
        {
            InitializeComponent();
            //this.BindingContext = id;
            //this.BindingContext
        }
        public int ContactId { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Command=new Command<ContactId>(); 
            //contactTableView.BindingContext = "ContactId";
            //workCell.Command= DisplayContactInfoCommand
            //Command = "{Binding DisplayContactInfoCommand}" CommandParameter = "id"
        }
    }
}
