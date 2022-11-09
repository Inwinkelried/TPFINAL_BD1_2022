using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Form_BD {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Conexion() {
            var conString = ConfigurationManager.ConnectionStrings["DBSQL"].ConnectionString;
            try {
                using (SqlConnection conector = new SqlConnection(conString)) {
                    conector.Open();
                    DataTable dt = new DataTable();
                    string query = @"Select * from MostrarPersonasConTrabajo";
                    SqlCommand comando = new SqlCommand(query, conector);   
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.SelectCommand = comando;
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void EjecutarStoredProcedure() {
            var conString = ConfigurationManager.ConnectionStrings["DBSQL"].ConnectionString;
            try {
                using (SqlConnection conector = new SqlConnection(conString)) {
                    conector.Open();
                    string query = @"AddPersona";  
                    SqlCommand comando = new SqlCommand(query, conector);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@Nro_Doc", SqlDbType.Int).Value = int.Parse(txt_Nro_Doc.Text);
                    comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txt_Nombre.Text;
                    comando.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = txt_Direccion.Text;
                    comando.Parameters.Add("@Localidad", SqlDbType.NVarChar).Value = txt_Localidad.Text;
                    comando.Parameters.Add("@Telefono", SqlDbType.BigInt).Value = Int64.Parse(txt_Telefono.Text);
                    comando.Parameters.Add("@Posee_Trabajo", SqlDbType.Bit).Value = true;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Carga correcta");
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_CargarVista_Click(object sender, EventArgs e) {
            Conexion();
        }

        private void btn_AddPersona_Click(object sender, EventArgs e) {
            EjecutarStoredProcedure();
            Conexion();

        }
    }

    
}
