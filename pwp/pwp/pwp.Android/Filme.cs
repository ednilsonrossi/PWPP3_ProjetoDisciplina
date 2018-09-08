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
using SQLite;

namespace pwp.Droid
{
    class Filme
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public String Title { get; set; }

        public String Year { get; set; }

        public String Genre { get; set; }

        public String Plot { get; set; }

        public String Poster { get; set; }

        public String Production { get; set; }
    }
}