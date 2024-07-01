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
    public partial class Ver_inventario : Form
    {
        public Ver_inventario()
        {
            InitializeComponent();

            LoadDataGridView();

        }
        private void LoadDataGridView()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT inv.Id_parte, inv.Nombre_parte, inv.Marca_parte,inv.Cantidad_disponible,inv.Descripcion FROM inventario as inv  ORDER BY inv.Nombre_parte";

            // Crea un DataTable para contener los datos
            DataTable tabla_inventario = new DataTable();

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
                            adapter.Fill(tabla_inventario);
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
            dataGridView1.DataSource = tabla_inventario;

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

        private void button_agregar_parte_Click(object sender, EventArgs e)
        {
            Agregar_parte agregar_Parte = new Agregar_parte();
            this.Hide();
            agregar_Parte.ShowDialog();
            LoadDataGridView();
            this.Show();
        }

        private void button_modificar_parte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int Id_parte = int.Parse(selectedRow.Cells["Id_parte"].Value.ToString());
                this.Hide();
                Modificar_parte modificar_parte = new Modificar_parte(Id_parte);
                modificar_parte.ShowDialog();
                LoadDataGridView();
                this.Show();
            }
        }

        private void button_eliminar_parte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("¿Esta seguro que quiere eliminar la parte?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {


                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int Id_parte = int.Parse(selectedRow.Cells["Id_parte"].Value.ToString());
                    string query = "DELETE FROM inventario WHERE Id_parte = " + Id_parte.ToString();
                    string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        try
                        {
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar parte de inventario: " + ex.Message);
                            return;
                        }
                    }

                    LoadDataGridView();
                }
            }
        }
    }
}
