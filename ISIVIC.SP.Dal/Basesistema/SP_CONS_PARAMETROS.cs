using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_CONS_PARAMETROS
	{
		public SP_CONS_PARAMETROS(){ }

			public ParametrosResponse get_Parametros(Parametros parametros)
			{
				ParametrosResponse parametrosResponse = new ParametrosResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_CONS_PARAMETROS";
					cmd.Parameters.AddWithValue("@in_idparametro",parametros.idparametro);
					cmd.Parameters.AddWithValue("@in_descripcion",parametros.descripcion);
					cmd.Parameters.AddWithValue("@in_estado",parametros.estado);
					cmd.Parameters.AddWithValue("@in_rutempresa",parametros.rutempresa);
					cmd.Parameters.AddWithValue("@in_variablepost",parametros.variablepost);
					cmd.Parameters.AddWithValue("@in_navigateurl",parametros.navigateurl);
					parametrosResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Parametros>();
					parametrosResponse.ErrorCode = NCH.Fwk.Bd.MySql.ErrorCode;
					parametrosResponse.ErrorDescription = NCH.Fwk.Bd.MySql.ErrorDescription;
					}
					catch (Exception ex)
					{
					parametrosResponse.ErrorCode = "16";
					parametrosResponse.ErrorDescription = ex.Message;
					}
					return parametrosResponse;
			}
		}
	}

