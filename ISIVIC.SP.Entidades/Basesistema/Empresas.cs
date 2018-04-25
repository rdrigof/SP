using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Empresas
	{
		public Empresas(){ }


		public string ErrorCode
		{
			 get; set; 
		}
		public string ErrorDescription
		{
			 get; set; 
		}
		public int rutempresa
		{
			 get; set; 
		}
		public string dvrempresa
		{
			 get; set; 
		}
		public string nombreempresa
		{
			 get; set; 
		}
		public int rutrepresentante
		{
			 get; set; 
		}
		public string dvr
		{
			 get; set; 
		}
		public string direccion
		{
			 get; set; 
		}
		public string nro
		{
			 get; set; 
		}
		public string fono
		{
			 get; set; 
		}
		public string emailusuario
		{
			 get; set; 
		}
		public string emaildominio
		{
			 get; set; 
		}
		public string razonsocial
		{
			 get; set; 
		}
		public string codigoactividadeconomica
		{
			 get; set; 
		}
		public string unidadsii
		{
			 get; set; 
		}
		public string logo
		{
			 get; set; 
		}
		public Boolean estado
		{
			 get; set; 
		}
		public int parametrosdetalle_idparametrosdetalle
		{
			 get; set; 
		}
		public int parametrosdetalle_parametros_idparametro
		{
			 get; set; 
		}
		public int comunas_ciudades_regiones_paises_idpais
		{
			 get; set; 
		}
		public int comunas_ciudades_regiones_idregiones
		{
			 get; set; 
		}
		public int comunas_ciudades_idciudad
		{
			 get; set; 
		}
		public int comunas_idcomunas
		{
			 get; set; 
		}
	}
	public class EmpresasResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Empresas> result = new List<Empresas>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Empresas> Result { get => result; set => result = value; }
	}
}

