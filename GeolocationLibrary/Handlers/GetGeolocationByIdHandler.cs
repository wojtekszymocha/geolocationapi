using GeolocationLibrary.Models;
using GeolocationLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeolocationLibrary.Handlers
{
    public class GetGeolocationByIdHandler : IRequestHandler<GetGeolocationByIdQuery, GeolocationModel>
    {
        private readonly IMediator _mediator;

        public GetGeolocationByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        } 
        public async Task<GeolocationModel> Handle(GetGeolocationByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetGeolocationListQuery());
            var output = result.FirstOrDefault(x => x.id == request.Id);
            return output;

        }
    }
}
