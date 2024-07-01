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
    public partial class Agregar_reparacion_externa : Form
    {
        public Agregar_reparacion_externa()
        {
            InitializeComponent();
            LoadDataGridView_Equipos();
            LoadDataGridView_Proveedor();
        }

        private void LoadDataGridView_Equipos()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT Id_equipo, Nombre_equipo,Marca_equipo ,Modelo_equipo,Nro_serie_equipo as Nro_serie FROM equipo ORDER BY Nombre_equipo";

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
        private void LoadDataGridView_Proveedor()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT Id_proveedor, Nombre_proveedor FROM proveedor ORDER BY Nombre_proveedor";

            // Crea un DataTable para contener los datos
            DataTable tabla_proveedor = new DataTable();

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
                            adapter.Fill(tabla_proveedor);
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
            dataGridView2.DataSource = tabla_proveedor;

            // Configurar la selección de filas completas
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false; // Permitir solo la selección de una fila a la vez
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_guardar_rep_ext_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView2.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow_equipo = dataGridView1.SelectedRows[0];
                DataGridViewRow selectedRow_proveedor = dataGridView2.SelectedRows[0];

                int Id_equipo = int.Parse(selectedRow_equipo.Cells["Id_equipo"].Value.ToString());
                int Id_proveedor = int.Parse(selectedRow_proveedor.Cells["Id_proveedor"].Value.ToString());

                

                string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Insertar el nuevo equipo


                        string insertar_equipo_Query = "INSERT INTO reparacion_externa (Fecha_salida,Fecha_reentrada,equipo_Id_equipo,proveedor_Id_proveedor,reporte_proovedor) " +
                            "VALUES ( NOW() ,@Fecha_reentrada,@equipo_Id_equipo,@proveedor_Id_proveedor,@reporte_proovedor)";
                        using (MySqlCommand insertar_reparacion_externa_Command = new MySqlCommand(insertar_equipo_Query, connection))
                        {
                            insertar_reparacion_externa_Command.Parameters.AddWithValue("@Fecha_reentrada", DBNull.Value);
                            insertar_reparacion_externa_Command.Parameters.AddWithValue("@equipo_Id_equipo", Id_equipo);
                            insertar_reparacion_externa_Command.Parameters.AddWithValue("@proveedor_Id_proveedor", Id_proveedor);
                            insertar_reparacion_externa_Command.Parameters.AddWithValue("@reporte_proovedor", DBNull.Value);

                            insertar_reparacion_externa_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Reparacion externa guardada exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar reparación externa: " + ex.Message);
                    }
                }

            }
            else
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Debe seleccionar un equipo y proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button_agregar_proveedor_Click(object sender, EventArgs e)
        {
            Agregar_proveedor agregar_Proveedor = new Agregar_proveedor();
            this.Hide();
            agregar_Proveedor.ShowDialog();
            LoadDataGridView_Proveedor();
            this.Show();
        }
    }
}
