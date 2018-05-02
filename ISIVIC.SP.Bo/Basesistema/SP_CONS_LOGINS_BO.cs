using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISIVIC.SP.Dal.basesistema;
using Lai.Fwk.Security;

namespace ISIVIC.SP.Bo.Basesistema
{
    public static class SP_CONS_LOGINS_BO
    {
        public static NCH.Fwk.Entities.LoginsResponse get_Logins(NCH.Fwk.Entities.Logins login)
        {
            NCH.Fwk.Entities.LoginsResponse loginsResponse = new NCH.Fwk.Entities.LoginsResponse();
            //SP_CONS_LOGINS loginDal = new SP_CONS_LOGINS();

            LoginService loginService = new LoginService();

            loginsResponse = loginService.login(login.login, login.contraseña);
            
            return loginsResponse;
        }
    }
}
