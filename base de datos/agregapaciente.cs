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
    public partial class agregapaciente : Form
    {
        public agregapaciente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string query =
               "INSERT INTO Paciente values(@nombre,@paterno,@materno,@edad,@telefono)";
            conexion.conectar();
            SqlCommand comando = new SqlCommand(query, conexion.conectar());
            comando.Parameters.AddWithValue("@nombre", textBoxnombre.Text);
            comando.Parameters.AddWithValue("@paterno", textBoxpaterno.Text);
            comando.Parameters.AddWithValue("@materno", textBoxmaterno.Text);
            comando.Parameters.AddWithValue("@edad", textBoxedad.Text);
            comando.Parameters.AddWithValue("@telefono", textBoxtelefono.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
        }

        private void agregapaciente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
