using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_MANT_CORREOSNOTIFICA
	{
		public SP_MANT_CORREOSNOTIFICA(){ }

			public CorreosnotificaResponse get_Correosnotifica(Correosnotifica correosnotifica)
			{
				CorreosnotificaResponse correosnotificaResponse = new CorreosnotificaResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_MANT_CORREOSNOTIFICA";
					cmd.Parameters.AddWithValue("@in_idcorreosnotifica",correosnotifica.idcorreosnotifica);
					cmd.Parameters.AddWithValue("@in_nombre",correosnotifica.nombre);
					cmd.Parameters.AddWithValue("@in_emailcompleto",correosnotifica.emailcompleto);
					cmd.Parameters.AddWithValue("@in_usuario",correosnotifica.usuario);
					cmd.Parameters.AddWithValue("@in_dominio",correosnotifica.dominio);
					cmd.Parameters.AddWithValue("@in_contraseña",correosnotifica.contraseña);
					cmd.Parameters.AddWithValue("@in_puerto",correosnotifica.puerto);
					cmd.Parameters.AddWithValue("@in_smtpServer",correosnotifica.smtpServer);
					cmd.Parameters.AddWithValue("@in_estado",correosnotifica.estado);
					cmd.Parameters.AddWithValue("@in_fhmodifica",correosnotifica.fhmodifica);
					cmd.Parameters.AddWithValue("@in_loginmodifica",correosnotifica.loginmodifica);
					correosnotificaResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Correosnotifica>();
					correosnotificaResponse.ErrorCode = correosnotificaResponse.Result.First().ErrorCode;
					correosnotificaResponse.ErrorDescription = correosnotificaResponse.Result.First().ErrorDescription;
					}
					catch (Exception ex)
					{
					correosnotificaResponse.ErrorCode = "16";
					correosnotificaResponse.ErrorDescription = ex.Message;
					}
					return correosnotificaResponse;
			}
		}
	}

