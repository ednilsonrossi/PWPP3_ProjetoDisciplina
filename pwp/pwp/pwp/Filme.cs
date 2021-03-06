﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace pwp
{
    public class Filme
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public String Title { get; set; }

        public String Year { get; set; }

        public String Genre { get; set; }

        public String Plot { get; set; }

        public String Poster { get; set; }

        public String Production { get; set; }

        public string Response { get; set; }
        public string Error { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
