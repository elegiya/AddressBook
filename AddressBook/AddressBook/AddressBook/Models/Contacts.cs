using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AddressBook.Models
{
    [Table("Contacts")]
    public class Contacts
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Work { get; set; }

        public string Main { get; set; }
    }
}
