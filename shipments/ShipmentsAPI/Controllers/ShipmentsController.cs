using System.Web.Http;

namespace ShipmentsAPI.Controllers
{
    [Authorize]
    public class ShipmentsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
