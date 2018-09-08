using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SQLite.Net.Interop;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PWPP3_ProjetoDisciplina.iOS.Config))]

namespace PWPP3_ProjetoDisciplina.iOS
{
    class Config : IConfig
    {
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

        private ISQLitePlatform _plataforma;
        ISQLitePlatform IConfig.Platform
        {
            get
            {
                if(_plataforma == null)
                {
                    _plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return _plataforma;
            }
        }
    }
}