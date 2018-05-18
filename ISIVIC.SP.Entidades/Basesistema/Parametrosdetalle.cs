using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Parametrosdetalle
	{
		public Parametrosdetalle(){ }


		public int idparametrosdetalle
		{
			 get; set; 
		}
		public string nombre
		{
			 get; set; 
		}
		public Boolean estado
		{
			 get; set; 
		}
		public int rutempresa
		{
			 get; set; 
		}
		public int parametros_idparametro
		{
			 get; set; 
		}
		public string loginmodifica
		{
			 get; set; 
		}
		public DateTime fhmodifica
		{
			 get; set; 
		}
	}
	public class ParametrosdetalleResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Parametrosdetalle> result = new List<Parametrosdetalle>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Parametrosdetalle> Result { get => result; set => result = value; }
	}
}

