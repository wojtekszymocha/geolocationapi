using GeolocationLibrary;
using GeolocationLibrary.Commands;
using GeolocationLibrary.Models;
using GeolocationLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeolocationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "http://localhost:44370/", headers: "*", methods: "*")]
    public class GeolocationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IIpStackHandler _saveHandler;
        
        public GeolocationController(IMediator mediator, IHttpClientFactory clientFactory, IIpStackHandler saveHandler)
        {
            this._mediator = mediator;
            this._saveHandler = saveHandler;
        }
       
        // GET: api/<GeolocationController>
        [HttpGet]
        public async Task<List<GeolocationModel>> Get()
        {
          
            return await _mediator.Send(new GetGeolocationListQuery());
        }

        // GET api/<GeolocationController>/5
        [HttpGet("{id}")]
        public async Task<GeolocationModel> Get(int id)
        {
            return await _mediator.Send(new GetGeolocationByIdQuery(id));
        }

        // POST api/<GeolocationController>
        [HttpPost]
        public async Task<GeolocationModel> Post([FromBody] GeolocationModel geolocation)
        {
            return await _mediator.Send(new InsertGeolocationCommand(geolocation));
        }

    }
}
