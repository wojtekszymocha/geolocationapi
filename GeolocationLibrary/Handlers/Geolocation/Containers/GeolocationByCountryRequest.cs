using MediatR;

namespace GeolocationLibrary
{
    public class GeolocationByCountryRequest : IRequest<GeolocationResponse>
    {
        public string country { get; set; }
        public GeolocationByCountryRequest(string country)
        {
            this.country = country;
        }
    }
}
