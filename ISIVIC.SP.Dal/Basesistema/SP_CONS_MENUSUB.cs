using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_CONS_MENUSUB
	{
		public SP_CONS_MENUSUB(){ }

			public MenusubResponse get_Menusub(Menusub menusub)
			{
				MenusubResponse menusubResponse = new MenusubResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_CONS_MENUSUB";
					cmd.Parameters.AddWithValue("@in_idmenusub",menusub.idmenusub);
					cmd.Parameters.AddWithValue("@in_navigateurlsub",menusub.navigateurlsub);
					cmd.Parameters.AddWithValue("@in_textsub",menusub.textsub);
					cmd.Parameters.AddWithValue("@in_estadosub",menusub.estadosub);
					cmd.Parameters.AddWithValue("@in_menus_idmenus",menusub.menus_idmenus);
					cmd.Parameters.AddWithValue("@in_prioridadsub",menusub.prioridadsub);
					menusubResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Menusub>();
					menusubResponse.ErrorCode = menusubResponse.Result.First().ErrorCode;
					menusubResponse.ErrorDescription = menusubResponse.Result.First().ErrorDescription;
					}
					catch (Exception ex)
					{
					menusubResponse.ErrorCode = "16";
					menusubResponse.ErrorDescription = ex.Message;
					}
					return menusubResponse;
			}
		}
	}

