using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SistemaVendas.Api
{
    public class Vendas
    {
        public static async Task<List<Models.Vendas>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    //var token = App.Token;
                    //client.DefaultRequestHeaders.Add("X-Auth-Token", token);
                    var json = await client.GetStringAsync("http://35.199.88.198:8080/SistemaVendas/" + "vendas.json");
                    var vendas = JsonConvert.DeserializeObject<List<Models.Vendas>>(json);
                    return vendas;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
