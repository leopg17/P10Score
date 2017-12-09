using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace P10Score.Model
{
    class LoginModel
    {

        public async Task<string> Authenticate(string UserName, string Password)
        {
            using (HttpClient client = new HttpClient())
            {
                var uri = new Uri("Aqui va la url de mi API");

                var json = JsonConvert.SerializableObject(new

                    UserNotifications = UserName,
                    Password = PS.Security.Cryptography.GenerateSHA512String(Password)


            });
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(Uri, content).ConfigureAwait(false);
            string ans = await response.Content.ReadAsStringAsync();
        }
               

        
            
            
    }
}
