using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Speakers.Interfaces;
using System.IO;
using Xamarin.Forms;
using Speakers.Android.Platform;

[assembly: Dependency((typeof(SQLite_Android)))]
namespace Speakers.Android.Platform
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
            // An empty constructor is required for Xamarin Forms Dependency to work
        }
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            string dbName = "Speakers.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentsPath, dbName);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            SQLite.Net.SQLiteConnection connection = new SQLite.Net.SQLiteConnection(platform, path);
            return connection;
        }
    }
}