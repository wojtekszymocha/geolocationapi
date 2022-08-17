using GeolocationLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeolocationLibrary.Commands
{
    public class InsertGeolocationCommand : IRequest<GeolocationModel>
    {
        public InsertGeolocationCommand(GeolocationModel geolocation)
        {
            Geolocation = geolocation;
        }

        public GeolocationModel Geolocation { get; set; }
    }
}
