using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCH.Fwk.Bd;

namespace ISIVIC.SP.Dal.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
                    TableToStoredProdureMysql.GenerarSp(bd["Database"].ToString(), tabla["table_name"].ToString(), dtColumnas);
                }
            }
        }
    }
}
