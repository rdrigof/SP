using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Logins
	{
		public Logins(){ }
		public string ErrorCode
		{
			 get; set; 
		}
		public string ErrorDescription
		{
			 get; set; 
		}
		public int idlogin
		{
			 get; set; 
		}
		public string login
		{
			 get; set; 
		}
		public int rut
		{
			 get; set; 
		}
		public string dvr
		{
			 get; set; 
		}
		public string nombrecompleto
		{
			 get; set; 
		}
		public string contraseña
		{
			 get; set; 
		}
		public Boolean estado
		{
			 get; set; 
		}
		public string email
		{
			 get; set; 
		}
	}
	public class LoginsResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Logins> result = new List<Logins>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Logins> Result { get => result; set => result = value; }
	}
}

