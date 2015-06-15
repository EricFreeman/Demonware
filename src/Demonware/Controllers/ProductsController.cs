using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using Demonware.Models;
using Demonware.Response;

namespace Demonware.Controllers
{
    public class ProductsController : ApiController
    {
        public JsonResult<ResponseEnvelope<List<Product>>> GetProductsByBrand()
        {
            var productList = new List<Product>
            {
                new Product
                {
                    Brand="TestBrand",
                    Id="0001",
                    Name="TestProduct1"
                }
            };

            var result = ResponseBuilder.BuildForSuccess(productList, "Success");
            return Json(result);
        } 
    }
}