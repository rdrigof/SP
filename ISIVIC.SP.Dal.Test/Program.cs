using NCH.Fwk.Bd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIVIC.SP.Dal.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtBases = new DataTable();
            ISIVIC.SP.Dal.BdEschemas db = new BdEschemas();
            dtBases = db.listarBasesDatos();
            foreach (DataRow bd in dtBases.Rows)
            {
                DataTable dtTablas = new DataTable();
                dtTablas = db.listarTablas(bd["Database"].ToString());
                foreach (DataRow tabla in dtTablas.Rows)
                {
                    DataTable dtColumnas = new DataTable();
                    dtColumnas = db.listarColumnas(tabla["table_name"].ToString());

                    TableToClass.GenerarClase(bd["Database"].ToString(), tabla["table_name"].ToString(), dtColumnas);
                    TableToStoredProdureMysql.BdName = bd["Database"].ToString();
                    TableToStoredProdureMysql.Tabla = tabla["table_name"].ToString();
                    TableToStoredProdureMysql.DtColumnas = dtColumnas;
                    TableToStoredProdureMysql.GenerarSp();
                }
            }
        }
    }
}
