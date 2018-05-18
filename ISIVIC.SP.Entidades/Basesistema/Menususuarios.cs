using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Menususuarios
	{
		public Menususuarios(){ }


		public int idmenususuario
		{
			 get; set; 
		}
		public int menusub_idmenusub
		{
			 get; set; 
		}
		public string login
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
	public class MenususuariosResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Menususuarios> result = new List<Menususuarios>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Menususuarios> Result { get => result; set => result = value; }
	}
}

