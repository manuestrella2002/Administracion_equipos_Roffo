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
    public partial class Ver_actualizaciones_ordenes : Form
    {
        private int ID;
        public Ver_actualizaciones_ordenes(int id_orden)
        {
            InitializeComponent();
            ID = id_orden;
            Cargar_orden();
            LoadDataGridView();

        }

        private void Cargar_orden()
        {
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT Descripcion FROM orden_de_trabajo WHERE Id_orden = " + ID.ToString();


            // Conéctate a la base de datos y ejecuta la consulta
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Verificar si el valor no es null antes de agregarlo al ComboBox
                                if (!reader.IsDBNull(reader.GetOrdinal("Descripcion")))
                                {
                                    label_orden.Text = "ORDEN: " + (reader.GetString("Descripcion"));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                    return;
                }
            }

        }

        private void LoadDataGridView()
        {
            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT id_actualizacion, Descripcion, Fecha_actualizacion FROM actualizacion_ordenes_de_trabajo WHERE Id_orden_de_trabajo = " + ID.ToString();

            // Crea un DataTable para contener los datos
            DataTable tabla_ordenes = new DataTable();

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
                            adapter.Fill(tabla_ordenes);
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
            dataGridView1.DataSource = tabla_ordenes;

            // Configurar la selección de filas completas
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Permitir solo la selección de una fila a la vez


            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_volver_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
