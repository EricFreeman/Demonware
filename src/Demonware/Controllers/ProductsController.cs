using System.Web.Http;
using System.Web.Http.Results;
using Demonware.Models;
using Demonware.Response;
using RestSharp;
using RestSharp.Serializers;

namespace Demonware.Controllers
{
    public class ProductsController : ApiController
    {
        public JsonResult<ResponseEnvelope<Product>> GetProduct()
        {
            var client = new RestClient("https://dev01-ecom2-1800contacts.demandware.net/s/1800contacts");
            var request = new RestRequest("services/products/getProduct", Method.POST);
            request.AddParameter("productId", "002736");
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new JsonSerializer();
            var result = client.Execute<ResponseEnvelope<Product>>(request);

            return Json(result.Data);
        }

        public JsonResult<InitialState> GetInitialState()
        {
            var client = new RestClient("https://dev01-ecom2-1800contacts.demandware.net/s/1800contacts");
            var request = new RestRequest("services/app/getInitialState", Method.POST);
            request.AddParameter("productId", "002736");
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new JsonSerializer();
            var result = client.Execute<InitialState>(request);

            return Json(result.Data);
        }
    }
}