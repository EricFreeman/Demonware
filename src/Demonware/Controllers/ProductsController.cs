using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using Demonware.Models;
using Demonware.Request;
using Demonware.Response;
using RestSharp;
using RestSharp.Serializers;

namespace Demonware.Controllers
{
    [EnableCors(origins: "http://prototype.1800contacts.com", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        [HttpPost]
        public JsonResult<ResponseEnvelope<Product>> GetProduct(string id)
        {
            var result = Hell.HailSatan<ResponseEnvelope<Product>>("services/products/getProduct", Method.POST, new RequestParameter("productId", id));
            return Json(result.Data);
        }

        public JsonResult<InitialState> GetInitialState()
        {
            var result = Hell.HailSatan<InitialState>("services/app/getInitialState", Method.POST);
            return Json(result.Data);
        }
    }
}