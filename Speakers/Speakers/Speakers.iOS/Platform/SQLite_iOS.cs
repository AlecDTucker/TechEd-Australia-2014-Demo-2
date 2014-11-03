using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Speakers.Interfaces;
using Xamarin.Forms;
using Speakers.iOS.Platform;
using System.IO;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace Speakers.iOS.Platform
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {

        }


        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "speakers.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            string path = Path.Combine(libraryPath, sqliteFilename);

            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            SQLite.Net.SQLiteConnection connection = new SQLite.Net.SQLiteConnection(platform, path);

            // Return the database connection 
            return connection;
        }
    }
}