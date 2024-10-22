using Newtonsoft.Json;
using System.Text;
using Clean_Architecture.Application.DTOs;
using Microsoft.Extensions.Configuration;
namespace Clean_Architecture.Application.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public AuthService(HttpClient httpClient,IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["BaseUrl"];
        }

        public async Task<string> RegisterAndLoginAsync()
        {
           

            var registrationData = new
            {
                cnpjCpf = "12345678901", 
                userName = "exampleUser", 
                email = "example@example.com", 
                password = "StrongPassword123!", 
                indicador = "indicador", 
                razaoSocial = "Razão Social Exemplo", 
                telefone = "123456789" 
            };

            var endpoint = $"{_baseUrl}/Auth/CadastroDeUsuario";
            

            var registrationContent = new StringContent(JsonConvert.SerializeObject(registrationData), Encoding.UTF8, "application/json");

            
            var registerResponse = await _httpClient.PostAsync(endpoint, registrationContent);

            if (!registerResponse.IsSuccessStatusCode)
            {
                throw new Exception($"Erro no cadastro: {registerResponse.ReasonPhrase}");
            }

           
            var loginData = new
            {
                userName = "exampleUser", 
                password = "StrongPassword123!"
            };

          
            var loginUrl = $"{_baseUrl}/Auth/Login";

            var loginContent = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");

            
            var loginResponse = await _httpClient.PostAsync(loginUrl, loginContent);

            if (loginResponse.IsSuccessStatusCode)
            {
                var responseBody = await loginResponse.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseBody);
                return tokenResponse.Token; 
            }
            else
            {
                throw new Exception($"Erro no login: {loginResponse.ReasonPhrase}");
            }
        }
    }

}
