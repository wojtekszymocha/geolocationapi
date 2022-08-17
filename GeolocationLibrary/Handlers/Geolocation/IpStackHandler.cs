using System;
using System.Threading;
using System.Threading.Tasks;
using GeolocationApi.IpstackApi;
using GeolocationLibrary.DataAccess;
using MediatR;

namespace GeolocationLibrary
{
    public class IpStackHandler : IIpStackHandler
    {
        private readonly IIpStackService _service;
        private readonly IMediator _mediator;
        private readonly IGeolocationDataAccess _dataAccess;

        public IpStackHandler(IIpStackService service, IMediator mediator, IGeolocationDataAccess dataAccess)
        {
            this._service = service;
            this._mediator = mediator;
            this._dataAccess = dataAccess;
            
        }

        public async Task<IpStackResponse> Handle(IpStackRequest request, CancellationToken ct)
        {
            var rs = new IpStackResponse();
            // 1 krok Pobranie danych na podstawie API
            var ipStackResponse = await this._service.GetDatafromApiAsync(request.IP, ct);
            if (ipStackResponse == null)
            {
                throw new Exception("HEHE");
            }
            _dataAccess.InsertGeolocation(ipStackResponse);
            // 2 krok zapis do BD

            return rs;
        }
    }
}