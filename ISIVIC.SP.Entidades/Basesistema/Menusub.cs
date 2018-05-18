using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Menusub
	{
		public Menusub(){ }


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
		public int menus_idmenus
		{
			 get; set; 
		}
		public int prioridadsub
		{
			 get; set; 
		}
	}
	public class MenusubResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Menusub> result = new List<Menusub>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Menusub> Result { get => result; set => result = value; }
	}
}

