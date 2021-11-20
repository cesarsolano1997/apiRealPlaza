using realPlazaApi.Handler;
using realPlazaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace realPlazaApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        [Route("listProduct/{idShop}")]
        [HttpGet]
        public IHttpActionResult GetShop(int idShop)
        {
            ProductModel mall = new ProductModel();

            List<ProductModel> lstMall = mall.GetListProduct(idShop);

            return Json(new JsonResult<List<ProductModel>>(lstMall));
        }
    }
}
