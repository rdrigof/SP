using System;
using Entidades.Basesistema;
using ISIVIC.SP.Bo.Basesistema;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISIVIC.SP.Bo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            Logins login = new Logins();
            login.login = "rsoto";
            login.contraseña = "12345678";
            SP_CONS_LOGINS_BO.get_Logins(login);
        }
    }
}
