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
    public partial class borrarpaciente : Form
    {
        public borrarpaciente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Paciente where  id_paciente='" + textBoxborrapacrid_pac.Text + "'";
                conexion.conectar();
                string comprobacion =
                    "SELECT id_paciente from Paciente where id_paciente='" + textBoxborrapacrid_pac.Text + "'";
                SqlCommand cp = new SqlCommand(comprobacion, conexion.conectar());
                SqlDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand comando = new SqlCommand(query, conexion.conectar());
                    SqlDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion", "aviso", MessageBoxButtons.OK);
            }
        }
        public void cargarpaciente(DataGridView dvg)
        {
            DataTable dtpaciente = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter
                ("Select * from Paciente where id_paciente='" + textBoxborrapacrid_pac.Text + "'",conexion.conectar());
            da.Fill(dtpaciente);
            dvg.DataSource = dtpaciente;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cargarpaciente(dataGridViewpaciente);
        }
    }
}