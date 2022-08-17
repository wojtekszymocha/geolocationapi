using System.Collections.Generic;

namespace GeolocationLibrary.Models
{
    public class Security
    {
        public bool IsProxy { get; set; }
        public string ProxyType { get; set; }
        public bool IsCrawler { get; set; }
        public string CrawlerName { get; set; }
        public string CrawlerType { get; set; }
        public bool IsTor { get; set; }
        public string ThreatLevel { get; set; }
        public List<string> ThreatTypes { get; set; }
    }
}
