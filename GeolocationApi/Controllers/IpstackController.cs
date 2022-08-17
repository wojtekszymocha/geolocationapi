using GeolocationLibrary;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeolocationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IpstackController : BaseController
    {
        private const int OneMinuteInMilliseconds = 1000 * 60;

        private readonly IIpStackHandler _ipStackHandler; // zamien na ipstack WOJTEG
        private readonly IGetIpStackHandler _getIpStackHandler;
        private readonly IGeolocationByCountryHandler _geolocationByCountryHandler;
        private readonly IMediator _mediator;

        public IpstackController(IIpStackHandler ipStackHandler, IGetIpStackHandler getIpStackHandler, IGeolocationByCountryHandler geolocationByCountryHandler,IMediator mediator)
        {
            this._ipStackHandler = ipStackHandler;
            this._getIpStackHandler = getIpStackHandler;
            this._geolocationByCountryHandler = geolocationByCountryHandler;
            this._mediator = mediator;
        }


        [HttpGet]
        public async Task<GeolocationResponse> Get()
        {
            return await _getIpStackHandler.Handle(null, base.CancellationToken);
        }

        [HttpGet("{request}")]
        public async Task<GeolocationResponse> Get(string request)
        {
            //return await _geolocationByCountryHandler.Handle(request, base.CancellationToken);
            return await _mediator.Send(new GeolocationByCountryRequest(request));
        }

        //GET: api/<IPSTACKController>
        [HttpPost]
        public async Task<IpStackResponse> Post2([FromBody] IpStackRequest rq)
        {
            return await _ipStackHandler.Handle(rq, base.CancellationToken);
        }
    }
}
