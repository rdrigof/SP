using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_CONS_EMPRESAS
	{
		public SP_CONS_EMPRESAS(){ }

			public EmpresasResponse get_Empresas(Empresas empresas)
			{
				EmpresasResponse empresasResponse = new EmpresasResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_CONS_EMPRESAS";
					cmd.Parameters.AddWithValue("@in_rutempresa",empresas.rutempresa);
					cmd.Parameters.AddWithValue("@in_dvrempresa",empresas.dvrempresa);
					cmd.Parameters.AddWithValue("@in_nombreempresa",empresas.nombreempresa);
					cmd.Parameters.AddWithValue("@in_rutrepresentante",empresas.rutrepresentante);
					cmd.Parameters.AddWithValue("@in_dvr",empresas.dvr);
					cmd.Parameters.AddWithValue("@in_direccion",empresas.direccion);
					cmd.Parameters.AddWithValue("@in_nro",empresas.nro);
					cmd.Parameters.AddWithValue("@in_fono",empresas.fono);
					cmd.Parameters.AddWithValue("@in_emailusuario",empresas.emailusuario);
					cmd.Parameters.AddWithValue("@in_emaildominio",empresas.emaildominio);
					cmd.Parameters.AddWithValue("@in_razonsocial",empresas.razonsocial);
					cmd.Parameters.AddWithValue("@in_codigoactividadeconomica",empresas.codigoactividadeconomica);
					cmd.Parameters.AddWithValue("@in_unidadsii",empresas.unidadsii);
					cmd.Parameters.AddWithValue("@in_logo",empresas.logo);
					cmd.Parameters.AddWithValue("@in_estado",empresas.estado);
					cmd.Parameters.AddWithValue("@in_parametrosdetalle_idparametrosdetalle",empresas.parametrosdetalle_idparametrosdetalle);
					cmd.Parameters.AddWithValue("@in_parametrosdetalle_parametros_idparametro",empresas.parametrosdetalle_parametros_idparametro);
					cmd.Parameters.AddWithValue("@in_comunas_ciudades_regiones_paises_idpais",empresas.comunas_ciudades_regiones_paises_idpais);
					cmd.Parameters.AddWithValue("@in_comunas_ciudades_regiones_idregiones",empresas.comunas_ciudades_regiones_idregiones);
					cmd.Parameters.AddWithValue("@in_comunas_ciudades_idciudad",empresas.comunas_ciudades_idciudad);
					cmd.Parameters.AddWithValue("@in_comunas_idcomunas",empresas.comunas_idcomunas);
					empresasResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Empresas>();
					empresasResponse.ErrorCode = NCH.Fwk.Bd.MySql.ErrorCode;
					empresasResponse.ErrorDescription = NCH.Fwk.Bd.MySql.ErrorDescription;
					}
					catch (Exception ex)
					{
					empresasResponse.ErrorCode = "16";
					empresasResponse.ErrorDescription = ex.Message;
					}
					return empresasResponse;
			}
		}
	}

