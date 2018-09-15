using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
//using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(pwp.Droid.Config))]

namespace pwp.Droid
{
    class Config : IConfig
    {
       

        public string getLocalPath(string name) 
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, name);
        }

      
    }
}