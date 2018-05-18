using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_MANT_VMENUSUSUARIOS
	{
		public SP_MANT_VMENUSUSUARIOS(){ }

			public VmenususuariosResponse get_Vmenususuarios(Vmenususuarios vmenususuarios)
			{
				VmenususuariosResponse vmenususuariosResponse = new VmenususuariosResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_MANT_VMENUSUSUARIOS";
					cmd.Parameters.AddWithValue("@in_idmenusub",vmenususuarios.idmenusub);
					cmd.Parameters.AddWithValue("@in_navigateurlsub",vmenususuarios.navigateurlsub);
					cmd.Parameters.AddWithValue("@in_textsub",vmenususuarios.textsub);
					cmd.Parameters.AddWithValue("@in_estadosub",vmenususuarios.estadosub);
					cmd.Parameters.AddWithValue("@in_prioridadsub",vmenususuarios.prioridadsub);
					cmd.Parameters.AddWithValue("@in_menus_idmenus",vmenususuarios.menus_idmenus);
					cmd.Parameters.AddWithValue("@in_idmenus",vmenususuarios.idmenus);
					cmd.Parameters.AddWithValue("@in_text",vmenususuarios.text);
					cmd.Parameters.AddWithValue("@in_navigateurl",vmenususuarios.navigateurl);
					cmd.Parameters.AddWithValue("@in_estado",vmenususuarios.estado);
					cmd.Parameters.AddWithValue("@in_prioridad",vmenususuarios.prioridad);
					cmd.Parameters.AddWithValue("@in_idmenususuario",vmenususuarios.idmenususuario);
					cmd.Parameters.AddWithValue("@in_menusub_idmenusub",vmenususuarios.menusub_idmenusub);
					cmd.Parameters.AddWithValue("@in_login",vmenususuarios.login);
					cmd.Parameters.AddWithValue("@in_loginmodifica",vmenususuarios.loginmodifica);
					cmd.Parameters.AddWithValue("@in_fhmodifica",vmenususuarios.fhmodifica);
					vmenususuariosResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Vmenususuarios>();
					vmenususuariosResponse.ErrorCode = NCH.Fwk.Bd.MySql.ErrorCode;
					vmenususuariosResponse.ErrorDescription = NCH.Fwk.Bd.MySql.ErrorDescription;
					}
					catch (Exception ex)
					{
					vmenususuariosResponse.ErrorCode = "16";
					vmenususuariosResponse.ErrorDescription = ex.Message;
					}
					return vmenususuariosResponse;
			}
		}
	}

