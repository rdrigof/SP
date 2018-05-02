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
            NCH.Fwk.Entities.Logins login = new NCH.Fwk.Entities.Logins();
            login.login = "rsoto";
            login.contraseña = "12345678";
            SP_CONS_LOGINS_BO.get_Logins(login);
        }

        [TestMethod]
        public void Test_get_Menususuarios_asignados()
        {
            //SP_CONS_MENUS_USUARIOS_ASIGNADOS_BO.get_Menususuarios_asignados("rsoto");
        }

        [TestMethod]
        public void get_Menususuarios_no_asignados()
        {
            //SP_CONS_MENUS_USUARIOS_NO_ASIGNADOS_BO.get_Menususuarios_no_asignados("rsoto");
        }
    }
}
