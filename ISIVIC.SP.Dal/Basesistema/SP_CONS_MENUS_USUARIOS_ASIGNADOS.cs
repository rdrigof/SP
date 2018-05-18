using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_CONS_MENUS_USUARIOS_ASIGNADOS
    {
		public SP_CONS_MENUS_USUARIOS_ASIGNADOS(){ }

			public Menus_usuariosResponse get_Menususuarios(string login)
			{
                Menus_usuariosResponse menususuariosResponse = new Menus_usuariosResponse();
				try
				{
				    NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_CONS_MENUS_USUARIOS_ASIGNADOS";
					cmd.Parameters.AddWithValue("@in_login", login);
					menususuariosResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Menus_usuarios>();
					menususuariosResponse.ErrorCode = NCH.Fwk.Bd.MySql.ErrorCode;
					menususuariosResponse.ErrorDescription = NCH.Fwk.Bd.MySql.ErrorDescription;
				}
				catch (Exception ex)
				{
					menususuariosResponse.ErrorCode = "16";
					menususuariosResponse.ErrorDescription = ex.Message;
				}
				return menususuariosResponse;
			}
		}
	}

