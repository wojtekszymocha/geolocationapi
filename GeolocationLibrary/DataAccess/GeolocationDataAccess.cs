using GeolocationLibrary.Models;
using System.Collections.Generic;
using System.Linq;


namespace GeolocationLibrary.DataAccess
{
    public class GeolocationDataAccess : IGeolocationDataAccess
    {
        private List<GeolocationModel> Geolocations = new();
        
        public GeolocationDataAccess()
        {
            Geolocations.Add(new GeolocationModel { id = 1, ip = "123.123.123.123", type = "ipv4", ContinentCode = "PL" });
            Geolocations.Add(new GeolocationModel { id = 2, ip = "121.121.121.121", type = "ipv4", ContinentCode = "UK" });
        }
        
       
        public List<GeolocationModel> GetGeolocations()
        {
            return Geolocations;
        }
        public List<GeolocationModel> GetGeolocations(string country)
        {
            List<GeolocationModel> geolocationModel = new();
            
            foreach(var model in Geolocations)
            {
                if(model.country_name == country)
                {
                    geolocationModel.Add(model);
                }
            }
            return geolocationModel;
        }

        public GeolocationModel InsertGeolocation(GeolocationModel geolocation)
        {
            GeolocationModel model = new();
            model = geolocation;
            model.id = Geolocations.Max(x => x.id) + 1;
            Geolocations.Add(model);
            return model;
        }

    }
}
