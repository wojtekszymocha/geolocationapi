using GeolocationLibrary.Models;
using System.Threading;
using System.Threading.Tasks;

namespace GeolocationApi.IpstackApi
{
    public interface IIpStackService
    {
         Task<GeolocationModel> GetDatafromApiAsync(string ip, CancellationToken ct);
    }
}