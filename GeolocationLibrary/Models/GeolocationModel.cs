using System;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GeolocationLibrary.Models
{

    public class GeolocationModel
    {
        public int id { get; set; }
        public string ip { get; set; }
        public string type { get; set; }
        [JsonPropertyName("continent_code")]
        public string ContinentCode { get; set; }
        public string continent_name { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string region_code { get; set; }
        public string region_name { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public float? latitude { get; set; }
        public float? longitude { get; set; }
        public Location location { get; set; }
    }
}
