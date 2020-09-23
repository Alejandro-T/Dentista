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
using System.Data.OracleClient;
namespace base_de_datos
{
    public partial class agregadoctores : Form
    {
        public agregadoctores()
        {
            InitializeComponent();
        }
        /*public DataTable cargarcbxdoctores()
        {
            SqlDataAdapter da = new SqlDataAdapter("LLENARCBXSERVICIO", conexion.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string query =
              "INSERT INTO doctores values(@nombre,@paterno,@materno,@edad,@telefono)";
            conexion.conectar();
            SqlCommand comando = new SqlCommand(query, conexion.conectar());
            comando.Parameters.AddWithValue("@nombre", textBoxnombredr.Text);
            comando.Parameters.AddWithValue("@paterno", textBoxpaternodr.Text);
            comando.Parameters.AddWithValue("@materno", textBoxmaternodr.Text);
            comando.Parameters.AddWithValue("@edad", textBoxedadr.Text);
            comando.Parameters.AddWithValue("@telefono", textBoxtelefodr.Text);
            //comando.Parameters.AddWithValue("@id_servicio", comboBoxdoctores.SelectedValue.ToString());

            comando.ExecuteNonQuery();
            MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
        }

        private void agregadoctores_Load(object sender, EventArgs e)
        {
            /*comboBoxdoctores.DataSource = cargarcbxdoctores();
            comboBoxdoctores.DisplayMember = "nombre";
            comboBoxdoctores.ValueMember = "id_servicio";*/
        }
    }
}
