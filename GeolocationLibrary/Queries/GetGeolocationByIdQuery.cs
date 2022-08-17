using GeolocationLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeolocationLibrary.Queries
{
    public class GetGeolocationByIdQuery :IRequest<GeolocationModel>
    {
        public int Id { get; }
        public GetGeolocationByIdQuery(int Id)
        {
            this.Id = Id;
        }
  
    }
}
