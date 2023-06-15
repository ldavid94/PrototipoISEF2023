using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion conexion = new Conexion();
        public OdbcDataReader getIdTipo()
        {
            string sql = "select pk_codtipoExam from tbl_tipoexamen;";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el codigo tipo examen de la tabla tbl_tipoexamen");
                return null;
            }
        }

        public OdbcDataReader getNombreTipo(string id)
        {
            string sql = "select nom_tipExam from tbl_tipoexamen where pk_codtipoExam = '" + id + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el nombre de tipo examen de la tabla tbl_tipoexamen");
                return null;
            }
        }
    }
}
