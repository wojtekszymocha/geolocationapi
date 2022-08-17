using MediatR;


namespace GeolocationLibrary
{
    public interface IGetIpStackHandler : IRequestHandler<GeolocationRequest, GeolocationResponse>
    {

    }
}
