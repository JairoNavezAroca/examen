using api_c_sharp.Common.DTO;

namespace api_c_sharp.Infraestructure
{
    public class ApiServiceController
    {
        private readonly string URL_API_PHP;
        private readonly string URL_API_NODE;
        
        public ApiServiceController(IConfiguration configuration)
        {
            URL_API_PHP = configuration["ApiPHP"].ToString();
            URL_API_NODE = configuration["ApiNodejs"].ToString();
        }

        public async Task<List<UserDTO>> GetUserList()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(URL_API_PHP);
            return await client.GetFromJsonAsync<List<UserDTO>>($"/api/users");
        }

        public async Task<List<TransactionDTO>> GetTransactionList()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(URL_API_NODE);
            return await client.GetFromJsonAsync<List<TransactionDTO>>($"/transactions");
        }
    }
}
