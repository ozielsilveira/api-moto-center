using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MotoCenter.Domain.Models.v1
{
    public class MotorcycleCategory
    {
        [JsonProperty("motorcycleId")]
        [JsonPropertyName("motorcycleId")]
        public int MotorcycleId { get; set; }

        [JsonProperty("motorcycle")]
        [JsonPropertyName("motorcycle")]
        public required Motorcycle Motorcycle { get; set; }

        [JsonProperty("categoryId")]
        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("category")]
        [JsonPropertyName("category")]
        public required Category Category { get; set; }
    }
}
