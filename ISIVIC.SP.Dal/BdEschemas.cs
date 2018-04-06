using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NCH.Fwk.Bd;
using NCH.Fwk.Configuration;

namespace ISIVIC.SP.Dal
{
    public class BdEschemas
    {
        public DataTable listarBasesDatos()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SHOW DATABASES;";
            NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConectNotBd;
            DataTable dt = new DataTable();
            dt = NCH.Fwk.Bd.MySql.executar(cmd);

            return dt;
        }
        public DataTable listarTablas(string baseDatos)
        {
            string query = "SELECT table_name FROM INFORMATION_SCHEMA.Tables WHERE table_schema = '" + baseDatos + "' ";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
            DataTable dt = new DataTable();
            dt = NCH.Fwk.Bd.MySql.executar(cmd);

            return dt;
        }
        public DataTable listarColumnas(string tabla)
        {
            string query = "SELECT COLUMN_NAME, DATA_TYPE,COLUMN_KEY FROM INFORMATION_SCHEMA.columns WHERE table_name = '" + tabla + "'";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            NCH.Fwk.Bd.MySql.Coneccion = NCH.Fwk.Configuration.SettingsServices.MysqlConect;
            DataTable dt = new DataTable();
            dt = NCH.Fwk.Bd.MySql.executar(cmd);

            return dt;
        }
    }
}
