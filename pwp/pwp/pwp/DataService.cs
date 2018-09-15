using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace pwp
{
    class DataService
    {
        HttpClient client = new HttpClient();
        public async Task<Filme> GetFilmeAsync(String nomeFilme)
        {
            try
            {
                string url = "http://www.omdbapi.com/?Type=movie&apikey=29566135&t=" + nomeFilme;
                var response = await client.GetStringAsync(url);
                var filme = JsonConvert.DeserializeObject<Filme>(response);
                return filme;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
