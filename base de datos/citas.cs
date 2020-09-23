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
    public partial class citas : Form
    {
        public citas()
        {
            InitializeComponent();
        }
        public DataTable cargarcbcitas()
        {
            SqlDataAdapter da = new SqlDataAdapter("LLENARCBXSERVICIO", conexion.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable cargarcdr()
        {
            //int a = Convert.ToInt16(comboBoxcitas_tser.ValueMember);
           // string buscadoctor
            //        = "select nombre from servicio_has_Doctor join doctores on Doctor_id_doctor = id_doctor where servicio_id_servicio = '" + 2 + "'";
            
            
            SqlDataAdapter dx = new SqlDataAdapter("LLENARCBXDOCTORE", conexion.conectar());
            dx.SelectCommand.CommandType = CommandType.StoredProcedure;
            dx.SelectCommand.Parameters.AddWithValue("@id_servicio",comboBoxcitas_tser.SelectedValue);
            DataTable ds = new DataTable();
            dx.Fill(ds);
            return ds;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
                string query = "INSERT INTO consulta values(@servicio_has_Doctor_Doctor_id_doctor,@servicio_has_Doctor_servicio_id_servicio,@Paciente_id_paciente)";
                
                string comprobacion =
                    "SELECT id_paciente from Paciente where id_paciente='" + textBoxid_pac_citas.Text + "'";
                SqlCommand cp = new SqlCommand(comprobacion, conexion.conectar());
                SqlDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                   
                    conexion.conectar();
                    SqlCommand comando = new SqlCommand(query, conexion.conectar());

                    comando.Parameters.AddWithValue("@Paciente_id_paciente", textBoxid_pac_citas.Text);
                    comando.Parameters.AddWithValue
                        ("@servicio_has_Doctor_servicio_id_servicio", comboBoxcitas_tser.SelectedValue.ToString());
                    comando.Parameters.AddWithValue
                        ("@servicio_has_Doctor_Doctor_id_doctor", comboBoxcitadocrdisp.SelectedValue.ToString());
                    //MessageBox.Show(comboBoxcitas_tser.SelectedValue.ToString());
                    //MessageBox.Show(comboBoxcitadocrdisp.SelectedValue.ToString());
                    comando.ExecuteNonQuery();
                    MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "aviso", MessageBoxButtons.OK);
                }
            
            
        }

        private void citas_Load(object sender, EventArgs e)
        {
            comboBoxcitas_tser.DataSource = cargarcbcitas();
            comboBoxcitas_tser.DisplayMember = "nombre";
            comboBoxcitas_tser.ValueMember = "id_servicio";
        }

        private void comboBoxcitas_tser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxcitadocrdisp.DataSource = cargarcdr();
            comboBoxcitadocrdisp.DisplayMember = "nombre";
            comboBoxcitadocrdisp.ValueMember = "id_doctor";
            
        }

        private void comboBoxcitas_tser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxcitadocrdisp.DataSource = cargarcdr();
            comboBoxcitadocrdisp.DisplayMember = "nombre";
            comboBoxcitadocrdisp.ValueMember = "id_doctor";
        }
    }
}
