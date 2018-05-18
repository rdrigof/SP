using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Correosnotifica
	{
		public Correosnotifica(){ }


		public int idcorreosnotifica
		{
			 get; set; 
		}
		public string nombre
		{
			 get; set; 
		}
		public string emailcompleto
		{
			 get; set; 
		}
		public string usuario
		{
			 get; set; 
		}
		public string dominio
		{
			 get; set; 
		}
		public string contraseña
		{
			 get; set; 
		}
		public string puerto
		{
			 get; set; 
		}
		public string smtpServer
		{
			 get; set; 
		}
		public Boolean estado
		{
			 get; set; 
		}
		public DateTime fhmodifica
		{
			 get; set; 
		}
		public string loginmodifica
		{
			 get; set; 
		}
	}
	public class CorreosnotificaResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Correosnotifica> result = new List<Correosnotifica>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Correosnotifica> Result { get => result; set => result = value; }
	}
}

