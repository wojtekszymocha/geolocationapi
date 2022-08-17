using MediatR;

namespace GeolocationLibrary
{
    public interface IIpStackHandler : IRequestHandler<IpStackRequest, IpStackResponse>
    {
    }
}