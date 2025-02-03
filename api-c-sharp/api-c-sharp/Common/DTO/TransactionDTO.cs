using System.Text.Json.Serialization;

namespace api_c_sharp.Common.DTO
{
    public class TransactionDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("transaction_date")]
        public string TransactionDate { get; set; }
    }
}
