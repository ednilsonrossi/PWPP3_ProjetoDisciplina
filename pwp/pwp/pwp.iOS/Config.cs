using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(pwp.iOS.Config))]
namespace pwp.iOS
{
    class Config : IConfig
    {
        public string getLocalPath(string name)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            path = System.IO.Path.Combine(path, "..", "Library");
            return Path.Combine(path, name);
        }

        /*
        private string _diretorioDB;
        string IConfig.DiretorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(_diretorioDB))
                {
                    var diretorio = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    _diretorioDB = System.IO.Path.Combine(diretorio, "..", "Library");
                }
                return _diretorioDB;
            }
        }
        */
        
    }
}