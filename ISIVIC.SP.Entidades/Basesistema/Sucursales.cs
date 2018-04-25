using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Sucursales
	{
		public Sucursales(){ }


		public string ErrorCode
		{
			 get; set; 
		}
		public string ErrorDescription
		{
			 get; set; 
		}
		public int idsucursal
		{
			 get; set; 
		}
		public int rutempresa
		{
			 get; set; 
		}
		public string id_sii
		{
			 get; set; 
		}
		public string sucursal
		{
			 get; set; 
		}
		public string abreviacion
		{
			 get; set; 
		}
		public string direccion
		{
			 get; set; 
		}
		public string fono
		{
			 get; set; 
		}
		public Boolean estado
		{
			 get; set; 
		}
		public int ciudades_idciudad
		{
			 get; set; 
		}
	}
	public class SucursalesResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Sucursales> result = new List<Sucursales>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Sucursales> Result { get => result; set => result = value; }
	}
}

