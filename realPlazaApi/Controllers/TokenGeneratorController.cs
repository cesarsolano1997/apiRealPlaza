using realPlazaApi.Handler;
using realPlazaApi.Models;
using realPlazaApi.Token;
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
    [AllowAnonymous]
    [RoutePrefix("api/token")]
    public class TokenGeneratorController : ApiController
    {
        [Route("generate")]
        [HttpPost]
        public IHttpActionResult GenerateToken(UserModel model)
        {
            try
            {
                string token = TokenGenerator.GenerateTokenJwt(model.Email + model.Name);

                return Json(new JsonResult<string>(token));
            }
            catch (Exception ex)
            {
                return new InternalServerError("Ocurrió un error al generar el token");
            }
        }
    }
}
