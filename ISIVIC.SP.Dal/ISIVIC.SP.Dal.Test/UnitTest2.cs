using System;
using Entidades.Basesistema;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISIVIC.SP.Dal.Test
{
    [TestClass]
    public class SP_CONS_LOGINS_Test
    {
        [TestMethod]
        public void TestLogin()
        {
            Logins login = new Logins();
            login.login = "rsoto";
            login.contraseña = "12345678";
            Dal.basesistema.SP_CONS_LOGINS sp_login = new basesistema.SP_CONS_LOGINS();
            sp_login.get_Logins(login);
        }
    }
}
