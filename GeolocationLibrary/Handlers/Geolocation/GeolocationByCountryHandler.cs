using GeolocationLibrary.DataAccess;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GeolocationLibrary.Handlers.Geolocation
{
    public class GeolocationByCountryHandler : IGeolocationByCountryHandler
    {
        private readonly IGeolocationDataAccess _dataAccess;
        public GeolocationByCountryHandler(IGeolocationDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public Task<GeolocationResponse> Handle(GeolocationByCountryRequest request, CancellationToken cancellationToken)
        {
            var response = new GeolocationResponse();
            var li = _dataAccess.GetGeolocations(request.country);
            response.GeoLocation = li;
            return Task.FromResult(response);
        }
    }
}
