using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;
using NCH.Fwk.Cryptography;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_CONS_LOGINS
	{
		public SP_CONS_LOGINS(){ }

			public LoginsResponse get_Logins(Logins login)
			{
				LoginsResponse loginsResponse = new LoginsResponse();
				try
				{
                    Encript encript = new Encript();
                    login.contraseña = encript.Encriptar(login.contraseña);

                    NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_CONS_LOGINS";
                    cmd.Parameters.AddWithValue("@in_login", login.login);
                    cmd.Parameters.AddWithValue("@in_contraseña", login.contraseña);
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

