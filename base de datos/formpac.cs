using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace base_de_datos
{
    public partial class fromp : Form
    {
        public fromp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new agregapaciente());
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new agregadoctores());
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new citas());
        }
    }
}
