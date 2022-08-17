using MediatR;

namespace GeolocationLibrary
{
    public interface IGeolocationByCountryHandler : IRequestHandler<GeolocationByCountryRequest, GeolocationResponse>
    {

    }
}
