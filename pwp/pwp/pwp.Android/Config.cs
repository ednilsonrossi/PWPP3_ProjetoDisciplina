using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(pwp.Droid.Config))]

namespace pwp.Droid
{
    class Config : IConfig
    {
        private string directoryDB;
        public string DiretorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directoryDB))
                {
                    directoryDB = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                return directoryDB;
            }
        }

        /*private ISQLitePlatform platforma;
        public ISQLitePlatform Platform
        {
            get
            {
                if (platforma == null)
                {
                    platforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return platforma;
            }
        }
        */
    }
}