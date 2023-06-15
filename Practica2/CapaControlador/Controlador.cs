using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sentencias = new Sentencias();
        public OdbcDataReader llenaridtipoexamen()
        {
            return sentencias.getIdTipo();
        }

        public OdbcDataReader llenarcbxNomEamen(string id)
        {
            return sentencias.getNombreTipo(id);
        }
    }
}
