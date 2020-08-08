using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;



namespace AppInternet
{
    public class WSClient
    {
        public async Task<List<T>> Get<T>(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
