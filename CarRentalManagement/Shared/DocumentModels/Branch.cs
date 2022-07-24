using Newtonsoft.Json;
using System;

namespace CarRentalManagement.Shared.DocumentModels
{
    public class Branch
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
