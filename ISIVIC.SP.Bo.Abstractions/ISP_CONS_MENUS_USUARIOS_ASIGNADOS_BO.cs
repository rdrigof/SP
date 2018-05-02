using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Basesistema;

namespace ISIVIC.SP.Bo.Abstractions
{
    public interface ISP_CONS_MENUS_USUARIOS_ASIGNADOS_BO
    {
        Menus_usuariosResponse get_Menususuarios_asignados(string login);
    }
}
