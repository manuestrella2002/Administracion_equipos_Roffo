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
    public partial class Ver_reparacion_externa : Form
    {
        public Ver_reparacion_externa()
        {
            InitializeComponent();
            LoadDataGridView_abiertas();
            LoadDataGridView_cerrada();
        }

        private void LoadDataGridView_abiertas()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query1 = "SELECT re.Id_reparacion_externa, e.Nombre_equipo, re.Fecha_salida," +
                "p.Nombre_proveedor FROM reparacion_externa  AS re " +
                "LEFT OUTER JOIN equipo AS e ON e.Id_equipo = re.equipo_Id_equipo " +
                "LEFT OUTER JOIN proveedor as p ON p.Id_proveedor = re.proveedor_Id_proveedor " +
                "WHERE re.Fecha_reentrada IS NULL";

            // Crea un DataTable para contener los datos
            DataTable tabla_ordenes_abiertas = new DataTable();

            // Conéctate a la base de datos y ejecuta la consulta
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query1, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(tabla_ordenes_abiertas);
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
            dataGridView1.DataSource = tabla_ordenes_abiertas;

            // Configurar la selección de filas completas
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Permitir solo la selección de una fila a la vez


            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadDataGridView_cerrada()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query2 = "SELECT re.Id_reparacion_externa, e.Nombre_equipo, re.Fecha_salida, re.Fecha_reentrada," +
                "p.Nombre_proveedor, re.reporte_proovedor AS reporte FROM reparacion_externa  AS re " +
                "LEFT OUTER JOIN equipo AS e ON e.Id_equipo = re.equipo_Id_equipo " +
                "LEFT OUTER JOIN proveedor as p ON p.Id_proveedor = re.proveedor_Id_proveedor " +
                "WHERE re.Fecha_reentrada IS NOT NULL";

            // Crea un DataTable para contener los datos
            DataTable tabla_ordenes_cerradas = new DataTable();

            // Conéctate a la base de datos y ejecuta la consulta
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query2, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(tabla_ordenes_cerradas);
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
            dataGridView2.DataSource = tabla_ordenes_cerradas;

            // Configurar la selección de filas completas
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false; // Permitir solo la selección de una fila a la vez


            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button_volver_al_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_agregar_salida_Click(object sender, EventArgs e)
        {
            Agregar_reparacion_externa agregar_Reparacion_Externa = new Agregar_reparacion_externa();
            this.Hide();
            agregar_Reparacion_Externa.ShowDialog();
            LoadDataGridView_abiertas();
            LoadDataGridView_cerrada();

            this.Show();
            

        }

        private void button_marcar_regreso_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 )
            {

                DataGridViewRow selectedRow_reparacion = dataGridView1.SelectedRows[0];

                int Id_reparacion_externa = int.Parse(selectedRow_reparacion.Cells["Id_reparacion_externa"].Value.ToString());

                Cerrar_reparacion_externa cerrar_Reparacion_Externa = new Cerrar_reparacion_externa(Id_reparacion_externa);
                this.Hide();
                cerrar_Reparacion_Externa.ShowDialog();
                this.Show();
                LoadDataGridView_abiertas();
                LoadDataGridView_cerrada();
            }
            else
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Debe seleccionar un equipo en reparacion externa.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
