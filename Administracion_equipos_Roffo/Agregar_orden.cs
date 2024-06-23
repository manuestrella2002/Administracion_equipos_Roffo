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
    public partial class Agregar_orden : Form
    {
        public Agregar_orden()
        {
            InitializeComponent();
            LoadComboBoxData();
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

        private void button_crear_orden_Click(object sender, EventArgs e)
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


                        string insertar_orden_Query = "INSERT INTO orden_de_trabajo (Descripcion,Fecha_creacion_orden,Fecha_fin_orden,equipo_Id_equipo,Lugar_orden) VALUES (@Descripcion,NOW(),@Fecha_fin_orden,@equipo_Id_equipo,@Lugar_orden)";
                        using (MySqlCommand insertar_orden_Command = new MySqlCommand(insertar_orden_Query, connection))
                        {
                            insertar_orden_Command.Parameters.AddWithValue("@Descripcion", descripcion);
                            insertar_orden_Command.Parameters.AddWithValue("@Fecha_fin_orden", DBNull.Value);
                            insertar_orden_Command.Parameters.AddWithValue("@equipo_Id_equipo", DBNull.Value);
                            insertar_orden_Command.Parameters.AddWithValue("@Lugar_orden", lugar);
                            insertar_orden_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Orden creada exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear orden: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Esta seguro que quiere cancelar la orden?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
