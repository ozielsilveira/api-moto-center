using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MotoCenter.Domain.Models.v1
{
    public class Photo
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("motorcycleId")]
        [JsonPropertyName("motorcycleId")]
        public int MotorcycleId { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public required string Url { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonProperty("motorcycle")]
        [JsonPropertyName("motorcycle")]
        public Motorcycle? Motorcycle { get; set; }

    }
}
