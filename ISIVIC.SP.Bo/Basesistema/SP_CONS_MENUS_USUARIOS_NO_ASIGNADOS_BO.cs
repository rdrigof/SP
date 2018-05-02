using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Basesistema;
using ISIVIC.SP.Bo.Abstractions;
using ISIVIC.SP.Dal.basesistema;

namespace ISIVIC.SP.Bo.Basesistema
{
    public class SP_CONS_MENUS_USUARIOS_NO_ASIGNADOS_BO: ISP_CONS_MENUS_USUARIOS_NO_ASIGNADOS_BO
    {
        public Menus_usuariosResponse get_Menususuarios_no_asignados(string login)
        {
            Menus_usuariosResponse menus_usuariosResponse = new Menus_usuariosResponse();
            SP_CONS_MENUS_USUARIOS_NO_ASIGNADOS menus_asignados = new SP_CONS_MENUS_USUARIOS_NO_ASIGNADOS();

            menus_usuariosResponse = menus_asignados.get_Menususuarios_no_asignados(login);
            
            return menus_usuariosResponse;
        }
    }
}
