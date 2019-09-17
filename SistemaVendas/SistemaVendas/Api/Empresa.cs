using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SistemaVendas.Api
{
    public class Empresa
    {
        public static async Task<List<Models.Empresa>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    //var token = App.Token;
                    //client.DefaultRequestHeaders.Add("X-Auth-Token", token);
                    var json = await client.GetStringAsync("http://35.199.88.198:8080/SistemaVendas/" + "empresa.json");
                    var empresas = JsonConvert.DeserializeObject<List<Models.Empresa>>(json);
                    return empresas;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
