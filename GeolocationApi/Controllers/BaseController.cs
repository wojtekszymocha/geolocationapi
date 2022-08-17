using System.Threading;
using Microsoft.AspNetCore.Mvc;
using GeolocationLibrary;

namespace GeolocationApi.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        
        public CancellationToken CancellationToken 
        { 
            get
            {
                return new CancellationTokenSource(Consts.OneMinuteInMilliseconds).Token;
            }
        }
    }
}