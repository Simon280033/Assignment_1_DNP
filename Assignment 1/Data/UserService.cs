using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assigntment_2_Web_API
{
    public class UserService : IUserService
    {
        private string uri = "https://localhost:5001";

        private readonly HttpClient client;

        public UserService()
        {
            this.client = new HttpClient();
        }

        public async Task<User> GetUser(string userName)
        {
            Console.WriteLine("Getting user...");
            HttpResponseMessage reponse = await client.GetAsync(uri + "/Users?username=" + userName);
            
            if (!reponse.IsSuccessStatusCode)
            {
                throw new Exception("Error: " + reponse.ReasonPhrase);
            }

            string message = await reponse.Content.ReadAsStringAsync();
            Console.WriteLine("Response: " + message);

            User result = JsonSerializer.Deserialize<User>(message);
            
            Console.WriteLine("User: " + result.userName);
            
            return result;      
        }

        public async Task AddUserAsync(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PostAsync(uri + "/Users", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }        }
    }
}