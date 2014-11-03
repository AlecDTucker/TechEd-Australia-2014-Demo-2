using Speakers.Interfaces;
using Speakers.WinPhone.Platform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_WinPhone))]
namespace Speakers.WinPhone.Platform
{
    public class SQLite_WinPhone : ISQLite
    {
        public SQLite_WinPhone()
        {
            // A parameterless constructor is required for the Xamarin Forms Depenency Service
        }

        // Change return type to SQLiteDBConnection as soon as the NuGet packages have been brought in
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            // Add the platform specific WinPhone implementation once the NuGet packages have been brought in
            // Also add the platform specific implementations for the other two platforms

            string sqliteFilename = "speakers.db3";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);

            var platform = new SQLite.Net.Platform.WindowsPhone8.SQLitePlatformWP8();
            SQLite.Net.SQLiteConnection connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }

    }
}
