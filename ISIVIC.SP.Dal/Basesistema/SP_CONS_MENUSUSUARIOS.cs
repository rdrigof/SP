using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_CONS_MENUSUSUARIOS
	{
		public SP_CONS_MENUSUSUARIOS(){ }

			public MenususuariosResponse get_Menususuarios(Menususuarios menususuarios)
			{
				MenususuariosResponse menususuariosResponse = new MenususuariosResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_CONS_MENUSUSUARIOS";
					cmd.Parameters.AddWithValue("@in_idmenususuario",menususuarios.idmenususuario);
					cmd.Parameters.AddWithValue("@in_menusub_idmenusub",menususuarios.menusub_idmenusub);
					cmd.Parameters.AddWithValue("@in_login",menususuarios.login);
					cmd.Parameters.AddWithValue("@in_loginmodifica",menususuarios.loginmodifica);
					cmd.Parameters.AddWithValue("@in_fhmodifica",menususuarios.fhmodifica);
					menususuariosResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Menususuarios>();
					menususuariosResponse.ErrorCode = menususuariosResponse.Result.First().ErrorCode;
					menususuariosResponse.ErrorDescription = menususuariosResponse.Result.First().ErrorDescription;
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

