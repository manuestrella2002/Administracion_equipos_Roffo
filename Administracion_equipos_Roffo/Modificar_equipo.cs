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
    public partial class Modificar_equipo : Form
    {
        private int ID;
        public Modificar_equipo(int Id_equipo)
        {
            InitializeComponent();
            ID = Id_equipo;
            LoadComboBoxData();

            Mostrar_detalles(Id_equipo);
        }
        
        private void LoadComboBoxData()
        {
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";
            string query1 = "SELECT DISTINCT Marca_equipo FROM equipo";
            string query2 = "SELECT DISTINCT Ubicacion_equipo FROM equipo";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query1, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Verificar si el valor no es null antes de agregarlo al ComboBox
                                if (!reader.IsDBNull(reader.GetOrdinal("Marca_equipo")))
                                {
                                    comboBox_marca.Items.Add(reader.GetString("Marca_equipo"));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query2, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Verificar si el valor no es null antes de agregarlo al ComboBox
                                if (!reader.IsDBNull(reader.GetOrdinal("Ubicacion_equipo")))
                                {
                                    comboBox_ubicacion.Items.Add(reader.GetString("Ubicacion_equipo"));
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
            comboBox_marca.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_marca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_marca.AutoCompleteSource = AutoCompleteSource.ListItems;
            // Permitir que el ComboBox acepte texto no listado
            comboBox_ubicacion.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_ubicacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_ubicacion.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void Mostrar_detalles(int Id_equipo)
        {
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";
            
            // Define tu consulta SQL
            string id_equipo_string =Id_equipo.ToString();
            string query = "SELECT * FROM equipo WHERE Id_equipo ="+ id_equipo_string;

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
                                textBox_nombre_equipo.Text = reader["Nombre_equipo"].ToString();
                                textBox_modelo_equipo.Text = reader["Modelo_equipo"].ToString();
                                comboBox_marca.Text = reader["Marca_equipo"].ToString();
                                textBox_nro_serie_equipo.Text = reader["Nro_serie_equipo"].ToString();

                                if (reader["Fecha_fabricacion_equipo"] != DBNull.Value)
                                    dateTime_fecha_fab.Value = Convert.ToDateTime(reader["Fecha_fabricacion_equipo"]);
                                else
                                    dateTime_fecha_fab.Checked = false;

                                if (reader["Fecha_adquisicion_equipo"] != DBNull.Value)
                                    dateTime_fecha_adq.Value = Convert.ToDateTime(reader["Fecha_adquisicion_equipo"]);
                                else
                                    dateTime_fecha_adq.Checked = false;

                                comboBox_ubicacion.Text = reader["Ubicacion_equipo"].ToString();
                                comboBox_estado.Text = reader["Status_equipo"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos del equipo: " + ex.Message);
                }
            }
        }

        private void button_Guardar_cambios_Click(object sender, EventArgs e)
        {
            if (textBox_nombre_equipo.Text.Length == 0)
            {
                MessageBox.Show("Falta agregar nombre de equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // for Error 
            }
            else
            {
                string nombre_equipo = textBox_nombre_equipo.Text;
                string marca_equipo = comboBox_marca.Text;
                string modelo_equipo = textBox_modelo_equipo.Text;
                string nro_serie = textBox_nro_serie_equipo.Text;


                DateTime Fecha_fab = dateTime_fecha_fab.Value;
                string fechafabSQL = Fecha_fab.ToString("yyyy-MM-dd HH:mm:ss");



                DateTime Fecha_adq = dateTime_fecha_adq.Value;
                string fechaadqSQL = Fecha_adq.ToString("yyyy-MM-dd HH:mm:ss");

                string ubicacion = comboBox_ubicacion.Text;
                string estado = comboBox_estado.Text;

                string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Insertar el nuevo equipo


                        string insertar_equipo_Query = "UPDATE equipo SET Id_equipo =@id_equipo, Nombre_equipo = @nombre_equipo," +
                        "Modelo_equipo = @modelo_equipo, Marca_equipo = @marca_equipo," +
                        "Nro_serie_equipo = @nro_serie_equipo, Fecha_fabricacion_equipo = @Fecha_fabricacion_equipo, " +
                        "Fecha_adquisicion_equipo = @Fecha_adquisicion_equipo, Ubicacion_equipo = @Ubicacion_equipo, " +
                        "Status_equipo = @Status_equipo WHERE Id_equipo ="+ID.ToString();
                        using (MySqlCommand insertar_equipo_Command = new MySqlCommand(insertar_equipo_Query, connection))
                        {
                            insertar_equipo_Command.Parameters.AddWithValue("@nombre_equipo", nombre_equipo);
                            if (modelo_equipo.Length != 0)
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@modelo_equipo", modelo_equipo);
                            }
                            else
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@modelo_equipo", DBNull.Value);

                            }
                            if (marca_equipo.Length != 0)
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@marca_equipo", marca_equipo);
                            }
                            else
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@marca_equipo", DBNull.Value);
                            }
                            if (nro_serie.Length != 0)
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Nro_serie_equipo", nro_serie);
                            }
                            else
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Nro_serie_equipo", DBNull.Value);

                            }
                            if (dateTime_fecha_fab.Checked)
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Fecha_fabricacion_equipo", fechafabSQL);
                            }
                            else
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Fecha_fabricacion_equipo", DBNull.Value);
                            }

                            if (dateTime_fecha_adq.Checked)
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Fecha_adquisicion_equipo", fechaadqSQL);
                            }
                            else
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Fecha_adquisicion_equipo", DBNull.Value);
                            }
                            if (ubicacion.Length != 0)
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Ubicacion_equipo", ubicacion);
                            }
                            else
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Ubicacion_equipo", DBNull.Value);
                            }
                            if (estado.Length != 0)
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Status_equipo", estado);
                            }
                            else
                            {
                                insertar_equipo_Command.Parameters.AddWithValue("@Status_equipo", DBNull.Value);

                            }
                            insertar_equipo_Command.Parameters.AddWithValue("@id_equipo", ID);

                            insertar_equipo_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Equipo modificado exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el equipo: " + ex.Message);
                    }
                }
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Esta seguro que quiere cancelar la modificacion del equipo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
