using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MotoCenter.Application.Dtos.v1
{
    public class MotorcycleDto
    {
        [JsonProperty("model")]
        [JsonPropertyName("model")]
        public required string Model { get; set; }
        [JsonProperty("brand")]
        [JsonPropertyName("brand")]
        public required string Brand { get; set; }
        [JsonProperty("year")]
        [JsonPropertyName("year")]
        public int Year { get; set; }
        [JsonProperty("color")]
        [JsonPropertyName("color")]
        public required string Color { get; set; }
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

}
