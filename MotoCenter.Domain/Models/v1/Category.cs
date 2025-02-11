using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MotoCenter.Domain.Models.v1
{
    public class Category
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonProperty("motorcycleCategories")]
        [JsonPropertyName("motorcycleCategories")]
        public List<MotorcycleCategory>? MotorcycleCategories { get; set; }
    }
}
