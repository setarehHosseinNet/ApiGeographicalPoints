using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WebClint.Models
{
    public class CustomerRepository
    {
        private string apiUrl = "http://localhost:61501/api/Persens";
        private HttpClient _client;
        public CustomerRepository()
        {
            _client = new HttpClient();
        }
        public List<Persen> GetAllPersen()
        {
            var result = _client.GetStringAsync(apiUrl).Result;
            List<Persen> list = JsonConvert.DeserializeObject<List<Persen>>(result);
            return list;
        }

        public Persen GetPersenByID(int PersenID)
        {
            var result = _client.GetStringAsync(apiUrl + "/" + PersenID).Result;
            Persen persen = JsonConvert.DeserializeObject<Persen>(result);
            return persen;
        }
        public string AddPersen(Persen persn)
        {
            string JsonPrsen = JsonConvert.SerializeObject(persn);
            StringContent content = new StringContent(JsonPrsen, Encoding.UTF8, "application/json");
            var res = _client.PostAsync(apiUrl, content).Result;
            return res.ToString();
        }
        public void UpdatePersen(Persen persen)
        {
            string JsonPrsen = JsonConvert.SerializeObject(persen);
            StringContent content = new StringContent(JsonPrsen, Encoding.UTF8, "application/json");
            var res = _client.PutAsync(apiUrl, content).Result;

        }
        public void DeletPersen(int id)
        {
            var res = _client.DeleteAsync(apiUrl + "/" + id).Result;
        }

    }
    //public class Persen
    //{
       
    //}
}
