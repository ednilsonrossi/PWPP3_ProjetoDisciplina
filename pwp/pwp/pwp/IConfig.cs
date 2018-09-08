using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace pwp
{
    public interface IConfig
    {
        String DiretorioDB { get; }

        //ISQLitePlatform Platform { get; }
    }
}
