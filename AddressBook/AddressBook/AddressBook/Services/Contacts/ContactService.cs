using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Services.Database;
using SQLite;
using Xamarin.Forms;

namespace AddressBook.Services.Contacts
{
    public class ContactService : IContactService
    {
        private readonly SQLiteConnection _connection;

        public ContactService()
        {
            _connection = DependencyService.Get<ISQLite>().GetConnection();

            _connection.CreateTable<Models.Contacts>();
        }

        public IEnumerable<string> GetAllNames()
        {
            var allContacts = _connection.Table<Models.Contacts>().ToList();
            return allContacts?.Select(c => c.Name);
        }

        public Models.Contacts GetById(int id)
        {
            return _connection.Table<Models.Contacts>().Where(c => c.Id == id).First();
        }

        public void Add(Models.Contacts contact)
        {
            //var newContact = new Models.Contacts
            //{
            //    Name = contact.Name,
            //    Mobile = contact.Mobile,
            //    Work = contact.Work,
            //    Main = contact.Main
            //};
            _connection.Insert(contact);
        }

        public void Update(Models.Contacts contact)
        {
            //var newContact = _connection.Table<Models.Contacts>().Where(c => c.Id == contact.Id).First();
            //newContact.Name = contact.Name;
            //newContact.Mobile = contact.Mobile;
            //newContact.Work = contact.Work;
            //newContact.Main = contact.Main;
            _connection.Update(contact);
        }

        public void Delete(int id)
        {
            _connection.Delete(id);
        }
    }
}
