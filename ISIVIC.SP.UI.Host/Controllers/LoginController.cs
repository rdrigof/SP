using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ISIVIC.SP.Bo.Basesistema;
using ISIVIC.SP.UI.Host.Models;
using NCH.Fwk.Entities;
using Newtonsoft.Json;

namespace ISIVIC.SP.UI.Host.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        [ResponseType(typeof(String))]
        [Route("api/basesistema/validalogin"), HttpHead()]
        public async Task<HttpResponseMessage> get_Logins(LoginRequestModel request)
        {
            Logins login = new Logins();
            login.login = request.Login;
            login.contraseña = request.Password;

            var model = JsonConvert.SerializeObject(SP_CONS_LOGINS_BO.get_Logins(login), Formatting.Indented);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(model)
            };
        }
    }
}
