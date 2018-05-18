using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Vmenusub
	{
		public Vmenusub(){ }


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
	}
	public class VmenusubResponse
	{
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Vmenusub> result = new List<Vmenusub>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Vmenusub> Result { get => result; set => result = value; }
	}
}

