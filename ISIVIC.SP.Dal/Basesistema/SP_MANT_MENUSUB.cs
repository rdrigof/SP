using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_MANT_MENUSUB
	{
		public SP_MANT_MENUSUB(){ }

			public MenusubResponse get_Menusub(Menusub menusub)
			{
				MenusubResponse menusubResponse = new MenusubResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_MANT_MENUSUB";
					cmd.Parameters.AddWithValue("@in_idmenusub",menusub.idmenusub);
					cmd.Parameters.AddWithValue("@in_navigateurlsub",menusub.navigateurlsub);
					cmd.Parameters.AddWithValue("@in_textsub",menusub.textsub);
					cmd.Parameters.AddWithValue("@in_estadosub",menusub.estadosub);
					cmd.Parameters.AddWithValue("@in_menus_idmenus",menusub.menus_idmenus);
					cmd.Parameters.AddWithValue("@in_prioridadsub",menusub.prioridadsub);
					menusubResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Menusub>();
					menusubResponse.ErrorCode = NCH.Fwk.Bd.MySql.ErrorCode;
					menusubResponse.ErrorDescription = NCH.Fwk.Bd.MySql.ErrorDescription;
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

