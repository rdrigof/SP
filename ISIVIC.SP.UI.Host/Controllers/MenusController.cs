using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ISIVIC.SP.Bo.Abstractions;
using ISIVIC.SP.UI.Host.Models;
using NCH.Fwk.Entities;
using Newtonsoft.Json;

namespace ISIVIC.SP.UI.Host.Controllers
{
    [Lai.Fwk.Security.WebAPI.Authorize(Service = "MenusController", Program = "SP")]
    public class MenusController : ApiController
    {
        private readonly ISP_CONS_MENUS_USUARIOS_ASIGNADOS_BO _cons_MENUS_USUARIOS_ASIGNADOS_BO;
        private readonly ISP_CONS_MENUS_USUARIOS_NO_ASIGNADOS_BO _cons_MENUS_USUARIOS_NO_ASIGNADOS_BO;

        public MenusController(
            ISP_CONS_MENUS_USUARIOS_ASIGNADOS_BO cons_MENUS_USUARIOS_ASIGNADOS_BO,
            ISP_CONS_MENUS_USUARIOS_NO_ASIGNADOS_BO cons_MENUS_USUARIOS_NO_ASIGNADOS_BO
        )
        {
            this._cons_MENUS_USUARIOS_ASIGNADOS_BO = cons_MENUS_USUARIOS_ASIGNADOS_BO;
            this._cons_MENUS_USUARIOS_NO_ASIGNADOS_BO = cons_MENUS_USUARIOS_NO_ASIGNADOS_BO;
        }

        [HttpPost]
        [ResponseType(typeof(String))]
        [Route("api/basesistema/menuasignados"), HttpHead()]
        public async Task<HttpResponseMessage> get_Menususuarios_asignados(LoginMenuRequestModel request)
        {
            Logins login = new Logins();
            login.login = request.Login;

            var model = JsonConvert.SerializeObject(this._cons_MENUS_USUARIOS_ASIGNADOS_BO.get_Menususuarios_asignados("rsoto"), Formatting.Indented);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(model)
            };
        }

        [HttpPost]
        [ResponseType(typeof(String))]
        [Route("api/basesistema/menunoasignados"), HttpHead()]
        public async Task<HttpResponseMessage> get_Menususuarios_no_asignados(LoginMenuRequestModel request)
        {
            Logins login = new Logins();
            login.login = request.Login;

            var model = JsonConvert.SerializeObject(this._cons_MENUS_USUARIOS_NO_ASIGNADOS_BO.get_Menususuarios_no_asignados("rsoto"), Formatting.Indented);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(model)
            };
        }
    }
}
