using GeolocationLibrary.Models;
using System.Collections.Generic;

namespace GeolocationLibrary.DataAccess
{
    public interface IGeolocationDataAccess
    {
        List<GeolocationModel> GetGeolocations();
        List<GeolocationModel> GetGeolocations(string country);
        GeolocationModel InsertGeolocation(GeolocationModel geolocation);
    }
}