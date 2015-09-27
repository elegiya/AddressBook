using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services.Contacts
{
    public interface IContactService
    {
        IEnumerable<string> GetAllNames();

        Models.Contacts GetById(int id);

        int GetIdByName(string name);

        void Add(Models.Contacts contact);

        void Update(Models.Contacts contact);

        void Delete(int id);
    }
}
