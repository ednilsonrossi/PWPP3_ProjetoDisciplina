using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using Xamarin.Forms;
using SQLite;
using System.Threading.Tasks;


namespace pwp
{
    class AcessoDB
    {
        readonly SQLiteAsyncConnection conexao;
        //private SQLiteConnection conexao;
        

        public AcessoDB(string path)
        {
            //var config = DependencyService.Get<IConfig>();

            //conexao = new SQLite.SQLiteConnection(System.IO.Path.Combine(config.DiretorioDB, "banco.db3"));
            //conexao = new SQLiteAsyncConnection(System.IO.Path.Combine(config.DiretorioDB, "banco.db3"));
            conexao = new SQLiteAsyncConnection(path);

            //conexao.CreateTable<Filme>();
            conexao.CreateTableAsync<Filme>().Wait();
        }

        public void Insert(Filme filme)
        {
            //conexao.Insert(filme);
            conexao.InsertAsync(filme);
        }

        public void Delete(Filme filme)
        {
            //conexao.Delete(filme);
            conexao.DeleteAsync(filme);
        }

        public void Update(Filme filme)
        {
            //conexao.Update(filme);
            conexao.UpdateAsync(filme);
        }

        public Task<Filme> RecuperateById(int id)
        //public Filme RecuperateById(int id)
        {
            //return conexao.Table<Filme>().FirstOrDefault(c => c.Id == id);
            return conexao.Table<Filme>().Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public Task<List<Filme>> RecuperateAll()
        //public List<Filme> RecuperateAll()
        {
            //return conexao.Table<Filme>().OrderBy(c => c.Title).ToList();
            return conexao.Table<Filme>().OrderBy(c => c.Title).ToListAsync();
        }
        /*
        void IDisposable.Dispose()
        {
            conexao.Dispose();
            //conexao = null;
        }*/
    }
}
