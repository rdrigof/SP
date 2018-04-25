using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_CONS_VMENUSUB
	{
		public SP_CONS_VMENUSUB(){ }

			public VmenusubResponse get_Vmenusub(Vmenusub vmenusub)
			{
				VmenusubResponse vmenusubResponse = new VmenusubResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_CONS_VMENUSUB";
					cmd.Parameters.AddWithValue("@in_idmenusub",vmenusub.idmenusub);
					cmd.Parameters.AddWithValue("@in_navigateurlsub",vmenusub.navigateurlsub);
					cmd.Parameters.AddWithValue("@in_textsub",vmenusub.textsub);
					cmd.Parameters.AddWithValue("@in_estadosub",vmenusub.estadosub);
					cmd.Parameters.AddWithValue("@in_prioridadsub",vmenusub.prioridadsub);
					cmd.Parameters.AddWithValue("@in_menus_idmenus",vmenusub.menus_idmenus);
					cmd.Parameters.AddWithValue("@in_idmenus",vmenusub.idmenus);
					cmd.Parameters.AddWithValue("@in_text",vmenusub.text);
					cmd.Parameters.AddWithValue("@in_navigateurl",vmenusub.navigateurl);
					cmd.Parameters.AddWithValue("@in_estado",vmenusub.estado);
					cmd.Parameters.AddWithValue("@in_prioridad",vmenusub.prioridad);
					vmenusubResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Vmenusub>();
					vmenusubResponse.ErrorCode = vmenusubResponse.Result.First().ErrorCode;
					vmenusubResponse.ErrorDescription = vmenusubResponse.Result.First().ErrorDescription;
					}
					catch (Exception ex)
					{
					vmenusubResponse.ErrorCode = "16";
					vmenusubResponse.ErrorDescription = ex.Message;
					}
					return vmenusubResponse;
			}
		}
	}

