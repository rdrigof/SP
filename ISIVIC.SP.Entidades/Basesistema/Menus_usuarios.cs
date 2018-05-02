using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basesistema
{
	public class Menus_usuarios
    {
		public Menus_usuarios(){ }


		public string ErrorCode
		{
			 get; set; 
		}
		public string ErrorDescription
		{
			 get; set; 
		}
		public string text
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
        public int menus_idmenus
        {
            get; set;
        }
        public int prioridadsub
        {
            get; set;
        }

    }
	public class Menus_usuariosResponse
    {
		private string errorCode = string.Empty;
		private string errorDescription = string.Empty;
		private List<Menus_usuarios> result = new List<Menus_usuarios>();
		public string ErrorCode { get => errorCode; set => errorCode = value; }
		public string ErrorDescription { get => errorDescription; set => errorDescription = value; }
		public List<Menus_usuarios> Result { get => result; set => result = value; }
	}
}

