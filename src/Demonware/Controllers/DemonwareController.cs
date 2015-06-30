using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using Demonware.Models;
using Demonware.Request;
using Demonware.Response;
using RestSharp;

namespace Demonware.Controllers
{
    [EnableCors(origins: "http://prototype.1800contacts.com", headers: "*", methods: "*")]
    public class DemonwareController : ApiController
    {
        [HttpPost]
        public JsonResult<object> Post(RequestModel request)
        {
            if (request.Parameters == null)
            {
                request.Parameters = new RequestParameter[0];
            }

            var result = Hell.HailSatan<ResponseEnvelope<Product>>(request.Url, Method.POST, request.Parameters);
            return Json(result.Data as object);
        }
    }
}
