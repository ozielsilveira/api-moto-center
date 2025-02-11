using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MotoCenter.Domain.Models.v1
{
    public class Motorcycle
    {
        public Motorcycle(string model, string brand, int year, string color, decimal price, string? description)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            Price = price;
            Description = description;
        }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

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

        [JsonProperty("registrationDate")]
        [JsonPropertyName("registrationDate")]
        public DateTime RegistrationDate { get; set; }

        [JsonProperty("userId")]
        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonProperty("user")]
        [JsonPropertyName("user")]
        public User? User { get; set; }

        [JsonProperty("photos")]
        [JsonPropertyName("photos")]
        public List<Photo>? Photos { get; set; }

        [JsonProperty("motorcycleCategories")]
        [JsonPropertyName("motorcycleCategories")]
        public List<MotorcycleCategory>? MotorcycleCategories { get; set; }
    }
}
