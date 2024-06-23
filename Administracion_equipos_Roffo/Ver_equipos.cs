using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Administracion_equipos_Roffo
{
    public partial class Ver_equipos : Form
    {
        public Ver_equipos()
        {
            InitializeComponent();
            LoadDataGridView();
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

        }

        private void button_agregar_equipo_Click(object sender, EventArgs e)
        {

            Agregar_equipo agregar_Equipo = new Agregar_equipo();
            this.Hide();
            agregar_Equipo.ShowDialog();
            LoadDataGridView();
            this.Show();

        }

        private void button_modificar_equipo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("¿Esta seguro que quiere modificar este equipo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int Id_Equipo = int.Parse(selectedRow.Cells["Id_equipo"].Value.ToString());
                    this.Hide();
                    Modificar_equipo modificar_Equipo = new Modificar_equipo(Id_Equipo);
                    modificar_Equipo.ShowDialog();
                    LoadDataGridView();
                    this.Show();
                }
             
            }
        }

        private void button_eliminar_equipo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult Resultado;
                Resultado=MessageBox.Show("¿Esta seguro que quiere eliminar el equipo?", "Atención", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (Resultado==DialogResult.Yes)
                {
                    Eliminar_equipo();
                    LoadDataGridView();
                }
            }
           
        }

        private void Eliminar_equipo()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int Id_Equipo = int.Parse(selectedRow.Cells["Id_equipo"].Value.ToString());


                // Define la cadena de conexión a tu base de datos MySQL
                string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                // Define tu consulta SQL
                string query = "DELETE FROM equipo WHERE Id_equipo=" + Id_Equipo.ToString();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Equipo eliminado exitosamente.", "Mensaje", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el equipo: " + ex.Message);
                    }

                }

            }
        }

        private void button_volver_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
