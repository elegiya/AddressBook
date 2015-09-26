using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddressBook.Droid.Services.Database;
using AddressBook.Services.Database;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace AddressBook.Droid.Services.Database
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = System.IO.Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}