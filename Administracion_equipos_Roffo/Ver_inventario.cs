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
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT inv.Id_parte, inv.Nombre_parte, inv.Marca_parte,inv.Cantidad_disponible,inv.Descripcion,p.Nombre_proveedor as Proveedor_parte FROM inventario as inv LEFT OUTER JOIN proveedor as p on inv.proveedor_Id_proveedor = p.Id_proveedor ORDER BY inv.Nombre_parte";

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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void button_volver_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_agregar_parte_Click(object sender, EventArgs e)
        {

        }

        private void button_modificar_parte_Click(object sender, EventArgs e)
        {

        }

        private void button_eliminar_parte_Click(object sender, EventArgs e)
        {

        }
    }
}
