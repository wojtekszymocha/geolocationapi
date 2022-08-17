using GeolocationLibrary.Commands;
using GeolocationLibrary.DataAccess;
using GeolocationLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeolocationLibrary.Handlers
{
    public class InsertGeolocationHandler:IRequestHandler<InsertGeolocationCommand, GeolocationModel>
    {
        private readonly IGeolocationDataAccess _dataAccess;

        public InsertGeolocationHandler(IGeolocationDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<GeolocationModel> Handle(InsertGeolocationCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InsertGeolocation(request.Geolocation));
        }
    }
}
