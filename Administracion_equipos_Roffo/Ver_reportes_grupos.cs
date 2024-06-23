using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_equipos_Roffo
{
    public partial class Ver_reportes_grupos : Form
    {
        public Ver_reportes_grupos()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT Id_reporte_grupo as Id_reporte,Fecha,Observaciones_grupo as Observaciones FROM reporte_grupo_electrogeno ORDER BY Fecha DESC";

            // Crea un DataTable para contener los datos
            DataTable tabla_equipos = new DataTable();

            // Conéctate a la base de datos y ejecuta la consulta
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(tabla_equipos);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                    return;
                }
            }


            // Asignar el DataTable como origen de datos del DataGridView
            dataGridView1.DataSource = tabla_equipos;

            // Configurar la selección de filas completas
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Permitir solo la selección de una fila a la vez

        }

        private void button_ver_reporte_completo_Click(object sender, EventArgs e)
        {

        }

        private void button_eliminar_reporte_Click(object sender, EventArgs e)
        {

        }

        private void button_modificar_reporte_Click(object sender, EventArgs e)
        {

        }

        private void button_crear_reporte_Click(object sender, EventArgs e)
        {
            Agregar_reporte_grupo agregar_Reporte_Grupo = new Agregar_reporte_grupo();
            this.Hide();
            agregar_Reporte_Grupo.ShowDialog();
            LoadDataGridView();
            this.Show();

        }

        private void button_tendencias_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
