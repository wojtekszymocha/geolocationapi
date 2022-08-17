using MediatR;

namespace GeolocationLibrary
{
    //ZMIEN NA IPSTACK
    public class IpStackRequest : IRequest<IpStackResponse>
    {
        public string IP { get; set; }
    }
}