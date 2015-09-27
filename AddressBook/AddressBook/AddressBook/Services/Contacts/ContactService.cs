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

        public int GetIdByName(string name)
        {
            return _connection.Table<Models.Contacts>().Where(c => c.Name == name).First()?.Id ?? 0;
        }

        public void Add(Models.Contacts contact)
        {
            _connection.Insert(contact);
        }

        public void Update(Models.Contacts contact)
        {
            _connection.Update(contact);
        }

        public void Delete(int id)
        {
            _connection.Delete(id);
        }
    }
}
