using realPlazaApi.Handler;
using realPlazaApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace realPlazaApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/shops")]
    public class ShopsController : ApiController
    {
        [Route("listShops/{idMall}")]
        [HttpGet]
        public IHttpActionResult GetShop(int idMall)
        {
            ShopModel shop = new ShopModel();

            List<ShopModel> lstShop = shop.GetListShop(idMall);

            return Json(new JsonResult<List<ShopModel>>(lstShop));
        }

    }
}
