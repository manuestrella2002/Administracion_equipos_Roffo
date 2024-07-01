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
    public partial class Ver_reportes_equipo : Form
    {

        private int ID;
        public Ver_reportes_equipo(int id_equipo)
        {
            InitializeComponent();
            ID = id_equipo;
            Mostar_datos();
            LoadDataGridView();
        }

        private void Mostar_datos()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT Nombre_equipo, Marca_equipo, Modelo_equipo, Nro_serie_equipo FROM equipo WHERE Id_equipo = " + ID.ToString();

      
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
                                if (!reader.IsDBNull(reader.GetOrdinal("Nombre_equipo")))
                                {
                                    label_equipo.Text ="Nombre equipo: " + (reader.GetString("Nombre_equipo"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Marca_equipo")))
                                {
                                    label_marca.Text = "Marca: " + (reader.GetString("Marca_equipo"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Modelo_equipo")))
                                {
                                    label_modelo.Text = "Modelo: " + (reader.GetString("Modelo_equipo"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Nro_serie_equipo")))
                                {
                                    label_nro_serie.Text = "Nro. de Serie: " + (reader.GetString("Nro_serie_equipo"));
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
            string query = "SELECT Id_reporte_equipo,Fecha ,Descripcion FROM reporte_equipo WHERE equipo_Id_equipo = " + ID.ToString() +
                " ORDER BY Fecha DESC ";

            // Crea un DataTable para contener los datos
            DataTable tabla_reporte = new DataTable();

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
                            adapter.Fill(tabla_reporte);
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
            dataGridView1.DataSource = tabla_reporte;

            // Configurar la selección de filas completas
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Permitir solo la selección de una fila a la vez
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_agregar_reporte_Click(object sender, EventArgs e)
        {
            Agregar_reporte_equipo agregar_Reporte_Equipo = new Agregar_reporte_equipo(ID);
            this.Hide();
            agregar_Reporte_Equipo.ShowDialog();
            this.Show();
            LoadDataGridView();
        }
    }
}
