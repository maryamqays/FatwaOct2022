using FatwaOct2022.Models;
using GoogleGson;
using Newtonsoft.Json;
using Org.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatwaOct2022.Services
{
    public class ApiService
    {
        public async Task<List<Root>> GetNews()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://fatwairaq.com/Articles/ListAsJson");

            //return JsonConvert.DeserializeObject<Root>(response);
            //return JsonConvert.DeserializeObject<List<Root>>(response);
            var des = (Root)Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(Root));

            return JsonConvert.DeserializeObject<List<Root>>(response);
            //return JsonConvert.DeserializeObject<List<Root>>(response).Cast<T>().ToList();
            //return (List<T>)JsonConvert.DeserializeObject<List<T>>(jsonString);

            //List<string> videogames = JsonConvert.DeserializeObject<List<string>>(response);

           // return JsonConvert.DeserializeObject <Root>(response);



        }
    }
}
