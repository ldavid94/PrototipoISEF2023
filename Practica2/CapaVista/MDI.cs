using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_examen mant = new Mant_examen();
            mant.Show();
        }
    }
}
