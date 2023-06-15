using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Mant_examen : Form
    {
        public Mant_examen()
        {
            InitializeComponent();
            llenarcbxidtipoexamen();
        }

        CapaControlador.Controlador controlador = new CapaControlador.Controlador();

        public void llenarcbxidtipoexamen()
        {
            try
            {
                cbxCodigo.Items.Clear();
                OdbcDataReader datareader = controlador.llenaridtipoexamen();
                while (datareader.Read())
                {
                    cbxCodigo.Items.Add(datareader[0].ToString());
                }
                cbxCodigo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxnombretipo()
        {
            try
            {
                cbxNombre.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxNomEamen(cbxCodigo.Text);
                while (datareader.Read())
                {
                    cbxNombre.Items.Add(datareader[0].ToString());
                }
                cbxNombre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_id_tipo.Text = cbxCodigo.Text;
            llenarcbxnombretipo();
        }

        private void cbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_nombre.Text = cbxNombre.Text;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4001";
            TextBox[] Grupotextbox = { txt_id, txt_id_tipo, txt_nombre, txt_precio };
            TextBox[] Idtextbox = { txt_id, txt_id_tipo, txt_nombre, txt_precio };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_examenes;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_examenes, Grupotextbox, "colchoneria");
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Reporte ver = new Reporte();
            ver.Show();
        }
    }
}
