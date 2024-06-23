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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void button_ver_equipos_Click(object sender, EventArgs e)
        {
            Ver_equipos ver_Equipos = new Ver_equipos();

            this.Hide();
            ver_Equipos.ShowDialog();
            LoadDataGridView();
            this.Show();

        }
        private void LoadDataGridView()
        {

            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query = "SELECT ot.Id_orden, ot.Descripcion,ot.Fecha_creacion_orden, e.Nombre_equipo as Equipo_asociado, ot.Lugar_orden FROM orden_de_trabajo as ot LEFT OUTER JOIN equipo as e on ot.equipo_Id_equipo=e.Id_equipo WHERE ot.Fecha_fin_orden IS NULL  ORDER BY ot.Fecha_creacion_orden DESC";

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
               dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void button_ver_ordenes_inactivas_Click(object sender, EventArgs e)
        {
            Ver_ordenes_inactivas ver_Ordenes_Inactivas = new Ver_ordenes_inactivas();
            this.Hide();
            ver_Ordenes_Inactivas.ShowDialog();
            LoadDataGridView();
            this.Show();
        }

        private void button_cerrar_orden_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("¿Esta seguro que quiere cerrar la orden?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado==DialogResult.Yes) 
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int Id_orden= int.Parse(selectedRow.Cells["Id_orden"].Value.ToString());


                    // Define la cadena de conexión a tu base de datos MySQL
                    string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                    // Define tu consulta SQL
                    string query = "UPDATE orden_de_trabajo SET Fecha_fin_orden = NOW() WHERE Id_orden=" + Id_orden.ToString();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Orden cerrada exitosamente.", "Mensaje", MessageBoxButtons.OK);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cerrar orden: " + ex.Message);
                        }

                    }
                    LoadDataGridView();
                }
                
                

            }
        }

        private void button_nueva_orden_Click(object sender, EventArgs e)
        {
            Agregar_orden agregar_Orden = new Agregar_orden();
            this.Hide();
            agregar_Orden.ShowDialog();
            LoadDataGridView();
            this.Show();
        }

        private void button_modificar_orden_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("¿Esta seguro que quiere modificar la orden?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int Id_orden = int.Parse(selectedRow.Cells["Id_orden"].Value.ToString());
                    Modificar_orden modificar_orden = new Modificar_orden(Id_orden);
                    this.Hide();
                    modificar_orden.ShowDialog();
                    LoadDataGridView();
                    this.Show();

                }
            }
        
                   
        }

        private void button_asociar_equipo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                
                DialogResult Resultado;
                Resultado = MessageBox.Show("¿Esta seguro que le quiere asociar un equipo a esta orden?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int Id_orden = int.Parse(selectedRow.Cells["Id_orden"].Value.ToString());
                    Asociar_equipo_orden asociar_Equipo_Orden = new Asociar_equipo_orden(Id_orden);
                    this.Hide();
                    asociar_Equipo_Orden.ShowDialog();
                    LoadDataGridView();
                    this.Show();

                }
            }
        }

        private void button_ver_grupos_Click(object sender, EventArgs e)
        {
            Ver_grupos_electrogenos ver_Grupos_Electrogenos = new Ver_grupos_electrogenos();
            this.Hide();
            ver_Grupos_Electrogenos.ShowDialog();
            LoadDataGridView();
            this.Show();
        }

        private void button_inventario_Click(object sender, EventArgs e)
        {
            Ver_inventario ver_inventario = new Ver_inventario();
            this.Hide();
            ver_inventario.ShowDialog();
            LoadDataGridView();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_reporte_grupo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_reporte_equipo_Click(object sender, EventArgs e)
        {

        }
    }
}
