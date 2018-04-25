using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Entidades.Basesistema;
using MySql.Data.MySqlClient;
using NCH.Fwk.Helpers;

namespace ISIVIC.SP.Dal.basesistema
{
	public class SP_CONS_SUCURSALES
	{
		public SP_CONS_SUCURSALES(){ }

			public SucursalesResponse get_Sucursales(Sucursales sucursales)
			{
				SucursalesResponse sucursalesResponse = new SucursalesResponse();
				try
				{
				NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.CommandText = "SP_CONS_SUCURSALES";
					cmd.Parameters.AddWithValue("@in_idsucursal",sucursales.idsucursal);
					cmd.Parameters.AddWithValue("@in_rutempresa",sucursales.rutempresa);
					cmd.Parameters.AddWithValue("@in_id_sii",sucursales.id_sii);
					cmd.Parameters.AddWithValue("@in_sucursal",sucursales.sucursal);
					cmd.Parameters.AddWithValue("@in_abreviacion",sucursales.abreviacion);
					cmd.Parameters.AddWithValue("@in_direccion",sucursales.direccion);
					cmd.Parameters.AddWithValue("@in_fono",sucursales.fono);
					cmd.Parameters.AddWithValue("@in_estado",sucursales.estado);
					cmd.Parameters.AddWithValue("@in_ciudades_idciudad",sucursales.ciudades_idciudad);
					sucursalesResponse.Result = NCH.Fwk.Bd.MySql.executar(cmd).ToList<Sucursales>();
					sucursalesResponse.ErrorCode = sucursalesResponse.Result.First().ErrorCode;
					sucursalesResponse.ErrorDescription = sucursalesResponse.Result.First().ErrorDescription;
					}
					catch (Exception ex)
					{
					sucursalesResponse.ErrorCode = "16";
					sucursalesResponse.ErrorDescription = ex.Message;
					}
					return sucursalesResponse;
			}
		}
	}

