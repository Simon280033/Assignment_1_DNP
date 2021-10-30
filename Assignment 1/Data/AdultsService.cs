using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assigntment_2_Web_API
{
    public class AdultsService : IAdultsService
    {
        private string uri = "https://localhost:5001";

        private readonly HttpClient client;

        public AdultsService()
        {
            this.client = new HttpClient();
        }
        
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpResponseMessage reponse = await client.GetAsync(uri + "/Adults");
            if (!reponse.IsSuccessStatusCode)
            {
                throw new Exception("Error or whatever");
            }

            string message = await reponse.Content.ReadAsStringAsync();
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            Console.WriteLine("List size: " + result.Count);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PostAsync(uri + "/Adults", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{uri}/Adults/{adultId}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task UpdateAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PatchAsync($"{uri}/Adults/{adult.id}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }      
        }
    }
}