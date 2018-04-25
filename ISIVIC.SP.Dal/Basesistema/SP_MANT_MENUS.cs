using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_MANT_MENUS
	{
		public SP_MANT_MENUS(){ }

			public MenusResponse get_Menus(Menus menus)
			{
				MenusResponse menusResponse = new MenusResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_MANT_MENUS";
					cmd.Parameters.AddWithValue("@in_idmenus",menus.idmenus);
					cmd.Parameters.AddWithValue("@in_text",menus.text);
					cmd.Parameters.AddWithValue("@in_navigateurl",menus.navigateurl);
					cmd.Parameters.AddWithValue("@in_estado",menus.estado);
					cmd.Parameters.AddWithValue("@in_prioridad",menus.prioridad);
					menusResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Menus>();
					menusResponse.ErrorCode = menusResponse.Result.First().ErrorCode;
					menusResponse.ErrorDescription = menusResponse.Result.First().ErrorDescription;
					}
					catch (Exception ex)
					{
					menusResponse.ErrorCode = "16";
					menusResponse.ErrorDescription = ex.Message;
					}
					return menusResponse;
			}
		}
	}

