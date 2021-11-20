using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using realPlazaApi.Handler;
using realPlazaApi.Models;

namespace realPlazaApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/mall")]
    public class MallController : ApiController
    {
        [Route("listMall")]
        [HttpGet]
        public IHttpActionResult GetShop()
        {
            MallModel mall = new MallModel();

            List<MallModel> lstMall = mall.GetListMall();

            return Json(new JsonResult<List<MallModel>>(lstMall));
        }

    }
}
