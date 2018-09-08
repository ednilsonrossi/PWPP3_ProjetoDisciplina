using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace PWPP3_ProjetoDisciplina
{
    public interface IConfig
    {
        String DiretorioDB { get; }

        ISQLitePlatform Platform { get; }
    }
}
