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
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(PWPP3_ProjetoDisciplina.Droid.Config))]

namespace PWPP3_ProjetoDisciplina.Droid
{
    class Config : IConfig
    {
        private String directoryDB;
        public string DiretorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directoryDB))
                {
                    directoryDB = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return directoryDB;
            }
        }

        private ISQLitePlatform platforma;
        public ISQLitePlatform Platform
        {
            get
            {
                if(platforma == null)
                {
                    platforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return platforma;
            }
        }
    }
}