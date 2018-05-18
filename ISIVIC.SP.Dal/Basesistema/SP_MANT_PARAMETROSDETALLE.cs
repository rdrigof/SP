using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_MANT_PARAMETROSDETALLE
	{
		public SP_MANT_PARAMETROSDETALLE(){ }

			public ParametrosdetalleResponse get_Parametrosdetalle(Parametrosdetalle parametrosdetalle)
			{
				ParametrosdetalleResponse parametrosdetalleResponse = new ParametrosdetalleResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_MANT_PARAMETROSDETALLE";
					cmd.Parameters.AddWithValue("@in_idparametrosdetalle",parametrosdetalle.idparametrosdetalle);
					cmd.Parameters.AddWithValue("@in_nombre",parametrosdetalle.nombre);
					cmd.Parameters.AddWithValue("@in_estado",parametrosdetalle.estado);
					cmd.Parameters.AddWithValue("@in_rutempresa",parametrosdetalle.rutempresa);
					cmd.Parameters.AddWithValue("@in_parametros_idparametro",parametrosdetalle.parametros_idparametro);
					cmd.Parameters.AddWithValue("@in_loginmodifica",parametrosdetalle.loginmodifica);
					cmd.Parameters.AddWithValue("@in_fhmodifica",parametrosdetalle.fhmodifica);
					parametrosdetalleResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Parametrosdetalle>();
					parametrosdetalleResponse.ErrorCode = NCH.Fwk.Bd.MySql.ErrorCode;
					parametrosdetalleResponse.ErrorDescription = NCH.Fwk.Bd.MySql.ErrorDescription;
					}
					catch (Exception ex)
					{
					parametrosdetalleResponse.ErrorCode = "16";
					parametrosdetalleResponse.ErrorDescription = ex.Message;
					}
					return parametrosdetalleResponse;
			}
		}
	}

