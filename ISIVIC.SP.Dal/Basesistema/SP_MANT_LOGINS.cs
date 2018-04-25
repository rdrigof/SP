using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_MANT_LOGINS
	{
		public SP_MANT_LOGINS(){ }

			public LoginsResponse get_Logins(Logins logins)
			{
				LoginsResponse loginsResponse = new LoginsResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_MANT_LOGINS";
					cmd.Parameters.AddWithValue("@in_idlogin",logins.idlogin);
					cmd.Parameters.AddWithValue("@in_login",logins.login);
					cmd.Parameters.AddWithValue("@in_rut",logins.rut);
					cmd.Parameters.AddWithValue("@in_dvr",logins.dvr);
					cmd.Parameters.AddWithValue("@in_nombrecompleto",logins.nombrecompleto);
					cmd.Parameters.AddWithValue("@in_contraseña",logins.contraseña);
					cmd.Parameters.AddWithValue("@in_estado",logins.estado);
					cmd.Parameters.AddWithValue("@in_email",logins.email);
					loginsResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Logins>();
					loginsResponse.ErrorCode = loginsResponse.Result.First().ErrorCode;
					loginsResponse.ErrorDescription = loginsResponse.Result.First().ErrorDescription;
					}
					catch (Exception ex)
					{
					loginsResponse.ErrorCode = "16";
					loginsResponse.ErrorDescription = ex.Message;
					}
					return loginsResponse;
			}
		}
	}

