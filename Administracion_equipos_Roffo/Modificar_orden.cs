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
    public partial class Modificar_orden : Form
    {
        private int ID;
        public Modificar_orden(int id_orden)
        {
            InitializeComponent();
            LoadComboBoxData();
            ID = id_orden;
            Mostrar_detalles(id_orden);
        }

        private void LoadComboBoxData()
        {
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";
            string query = "SELECT DISTINCT Lugar_orden FROM orden_de_trabajo";


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
                                if (!reader.IsDBNull(reader.GetOrdinal("Lugar_orden")))
                                {
                                    comboBox_lugar_orden.Items.Add(reader.GetString("Lugar_orden"));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }


            }

            // Permitir que el ComboBox acepte texto no listado
            comboBox_lugar_orden.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_lugar_orden.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_lugar_orden.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void Mostrar_detalles(int Id_orden)
        {
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string id_equipo_string = Id_orden.ToString();
            string query = "SELECT * FROM orden_de_trabajo WHERE Id_orden =" + id_equipo_string;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Asignar los valores obtenidos a los controles de edición
                                textBox_descripcion_orden.Text = reader["Descripcion"].ToString();
                                comboBox_lugar_orden.Text = reader["Lugar_orden"].ToString();
                               

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos de la orden: " + ex.Message);
                }
            }
        }

        private void button_guardar_cambios_Click(object sender, EventArgs e)
        {
            if (textBox_descripcion_orden.Text.Length == 0)
            {
                MessageBox.Show("Falta agregar descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // for Error 
            }
            else
            {
                string descripcion = textBox_descripcion_orden.Text;
                string lugar = comboBox_lugar_orden.Text;

                string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Insertar el nuevo equipo


                        string insertar_orden_Query = "UPDATE orden_de_trabajo SET Descripcion=@Descripcion, Lugar_orden=@Lugar_orden WHERE Id_orden="+ID.ToString();
                        using (MySqlCommand insertar_orden_Command = new MySqlCommand(insertar_orden_Query, connection))
                        {
                            insertar_orden_Command.Parameters.AddWithValue("@Descripcion", descripcion);
                            insertar_orden_Command.Parameters.AddWithValue("@Lugar_orden", lugar);
                            insertar_orden_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Orden modificada exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar orden: " + ex.Message);
                    }
                }
            }
        }
    }
}
