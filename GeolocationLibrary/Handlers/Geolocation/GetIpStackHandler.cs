using GeolocationLibrary.DataAccess;
using System.Threading;
using System.Threading.Tasks;

namespace GeolocationLibrary
{
    public class GetIpStackHandler : IGetIpStackHandler
    {
        private readonly IGeolocationDataAccess _dataAccess;

        public GetIpStackHandler(IGeolocationDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public Task<GeolocationResponse> Handle(GeolocationRequest request, CancellationToken cancellationToken)
        {
            var response = new GeolocationResponse();
            var li = _dataAccess.GetGeolocations();
            response.GeoLocation = li;
            return Task.FromResult(response);
        }
    }
}
