using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Windows.Storage;
using pwp.UWP;


[assembly: Dependency(typeof(Config))]
namespace pwp.UWP
{
    class Config : IConfig
    {
        public string getLocalPath(string name)
        {
            return System.IO.Path.Combine(ApplicationData.Current.LocalFolder.Path, name);
        }
    }
}
