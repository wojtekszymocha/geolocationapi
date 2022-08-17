using GeolocationLibrary.Models;
using System.Collections.Generic;

namespace GeolocationLibrary
{
    public class GeolocationResponse : BaseResponse
    {
        public List<GeolocationModel> GeoLocation { get; set; }
    }
}