using GeolocationLibrary.DataAccess;
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
    public class GetGeolocationListHandler : IRequestHandler<GetGeolocationListQuery, List<GeolocationModel>>
    {
        private readonly IGeolocationDataAccess _data;

        public GetGeolocationListHandler(IGeolocationDataAccess data)
        {
            _data = data;
        }
        public Task<List<GeolocationModel>> Handle(GetGeolocationListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetGeolocations());
        }
    }
}
