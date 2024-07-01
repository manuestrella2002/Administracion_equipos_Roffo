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
    public partial class Ver_grupos_electrogenos : Form
    {
        public Ver_grupos_electrogenos()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT * FROM grupo_electrogeno ORDER BY Nombre_grupo";

            // Crea un DataTable para contener los datos
            DataTable tabla_grupo = new DataTable();

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
                            adapter.Fill(tabla_grupo);
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
            dataGridView1.DataSource = tabla_grupo;

            // Configurar la selección de filas completas
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Permitir solo la selección de una fila a la vez
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button_modificar_grupo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DialogResult Resultado;
                Resultado = MessageBox.Show("¿Esta seguro que quiere modificar el grupo electrogeno?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int Id_grupo = int.Parse(selectedRow.Cells["Id_grupo"].Value.ToString());
                    Modificar_grupo modificar_Grupo = new Modificar_grupo(Id_grupo);
                    this.Hide();
                    modificar_Grupo.ShowDialog();
                    LoadDataGridView();
                    this.Show();

                }
            }
        }

        private void button_volver_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
