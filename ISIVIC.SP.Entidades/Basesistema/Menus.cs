using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Menus
	{
		public Menus(){ }


		public string ErrorCode
		{
			 get; set; 
		}
		public string ErrorDescription
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
	}
	public class MenusResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Menus> result = new List<Menus>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Menus> Result { get => result; set => result = value; }
	}
}

