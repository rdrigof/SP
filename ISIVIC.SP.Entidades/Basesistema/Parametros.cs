using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Parametros
	{
		public Parametros(){ }


		public string ErrorCode
		{
			 get; set; 
		}
		public string ErrorDescription
		{
			 get; set; 
		}
		public int idparametro
		{
			 get; set; 
		}
		public string descripcion
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
		public string variablepost
		{
			 get; set; 
		}
		public string navigateurl
		{
			 get; set; 
		}
	}
	public class ParametrosResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Parametros> result = new List<Parametros>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Parametros> Result { get => result; set => result = value; }
	}
}

