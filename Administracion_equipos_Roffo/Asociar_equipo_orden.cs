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
    public partial class Asociar_equipo_orden : Form
    {
        private int ID;
        public Asociar_equipo_orden(int id_orden)
        {
            InitializeComponent();
            LoadDataGridView();
            ID = id_orden;

        }
        private void LoadDataGridView()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT * FROM equipo ORDER BY Nombre_equipo";

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
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void button_asociar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int Id_equipo = int.Parse(selectedRow.Cells["Id_equipo"].Value.ToString());
                    string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Insertar el nuevo equipo


                            string insertar_orden_Query = "UPDATE orden_de_trabajo SET equipo_Id_equipo=" + Id_equipo.ToString()+ " WHERE Id_orden=" + ID.ToString();
                            using (MySqlCommand insertar_orden_Command = new MySqlCommand(insertar_orden_Query, connection))
                            {
                                insertar_orden_Command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Equipo asociado a orden exitosamente.", "Mensaje", MessageBoxButtons.OK);
                            this.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al modificar orden: " + ex.Message);
                        }
                    }
                

            }
            
        }

        private void button_crear_equipo_Click(object sender, EventArgs e)
        {

            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Esta seguro que quiere crear un equipo nuevo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                Agregar_equipo agregar_Equipo = new Agregar_equipo();
                this.Hide();
                agregar_Equipo.ShowDialog();
                LoadDataGridView();
                this.Show();
            }
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
