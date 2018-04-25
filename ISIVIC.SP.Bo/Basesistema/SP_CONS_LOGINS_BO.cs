using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Basesistema;
using ISIVIC.SP.Dal.basesistema;

namespace ISIVIC.SP.Bo.Basesistema
{
    public static class SP_CONS_LOGINS_BO
    {
        public static LoginsResponse get_Logins(Logins login)
        {
            LoginsResponse loginsResponse = new LoginsResponse();
            SP_CONS_LOGINS loginDal = new SP_CONS_LOGINS();

            loginsResponse = loginDal.get_Logins(login);

            return loginsResponse;
        }
    }
}
