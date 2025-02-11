using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MotoCenter.Domain.Models.v1
{
    public class User
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public required string Email { get; set; }

        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public required string Password { get; set; }

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public required string Phone { get; set; }

        [JsonProperty("motorcycles")]
        [JsonPropertyName("motorcycles")]
        public List<Motorcycle>? Motorcycles { get; set; }
    }
}
