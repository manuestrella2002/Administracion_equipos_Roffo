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
    public partial class Ver_ordenes_inactivas : Form
    {
        public Ver_ordenes_inactivas()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT ot.Id_orden, ot.Descripcion,ot.Fecha_creacion_orden, e.Nombre_equipo as Equipo_asociado, ot.Lugar_orden FROM orden_de_trabajo as ot LEFT OUTER JOIN equipo as e on ot.equipo_Id_equipo=e.Id_equipo WHERE ot.Fecha_fin_orden IS NULL  ORDER BY ot.Fecha_creacion_orden DESC";

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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void button_reabrir_orden_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("¿Esta seguro que quiere reabrir la orden?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int Id_orden = int.Parse(selectedRow.Cells["Id_orden"].Value.ToString());


                    // Define la cadena de conexión a tu base de datos MySQL
                    string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                    // Define tu consulta SQL
                    string query = "UPDATE orden_de_trabajo SET Fecha_fin_orden = @fecha_fin_orden WHERE Id_orden=" + Id_orden.ToString();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@fecha_fin_orden", DBNull.Value);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Orden reabierta exitosamente.", "Mensaje", MessageBoxButtons.OK);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al reabrir la orden: " + ex.Message);
                        }

                    }
                    LoadDataGridView();
                }

            }
        }

        private void button_volver_Dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
