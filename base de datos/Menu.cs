using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base_de_datos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void linklabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult yes = MessageBox.Show("Desea salir?", "aviso", MessageBoxButtons.YesNo);
            if (yes == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Operacion cancelada", "aviso", MessageBoxButtons.OK);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            conexion.conectar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fromp a = new fromp();
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            borrarpaciente b = new borrarpaciente();
            b.Show();
        }
    }
}
