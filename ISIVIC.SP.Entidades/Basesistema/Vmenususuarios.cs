using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Vmenususuarios
	{
		public Vmenususuarios(){ }


		public string ErrorCode
		{
			 get; set; 
		}
		public string ErrorDescription
		{
			 get; set; 
		}
		public int idmenusub
		{
			 get; set; 
		}
		public string navigateurlsub
		{
			 get; set; 
		}
		public string textsub
		{
			 get; set; 
		}
		public Boolean estadosub
		{
			 get; set; 
		}
		public int prioridadsub
		{
			 get; set; 
		}
		public int menus_idmenus
		{
			 get; set; 
		}
		public int idmenus
		{
			 get; set; 
		}
		public string text
		{
			 get; set; 
		}
		public string navigateurl
		{
			 get; set; 
		}
		public Boolean estado
		{
			 get; set; 
		}
		public int prioridad
		{
			 get; set; 
		}
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
	public class VmenususuariosResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Vmenususuarios> result = new List<Vmenususuarios>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Vmenususuarios> Result { get => result; set => result = value; }
	}
}

