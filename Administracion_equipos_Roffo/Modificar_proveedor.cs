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
    public partial class Modificar_proveedor : Form
    {

        private int ID;
        public Modificar_proveedor(int id_proveedor)
        {
            InitializeComponent();
            ID = id_proveedor;
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";
            string query1 = "SELECT DISTINCT Localidad_Direccion_proveedor FROM proveedor";
            string query2 = "SELECT * FROM proveedor WHERE Id_proveedor = " + ID.ToString();
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
                                if (!reader.IsDBNull(reader.GetOrdinal("Localidad_Direccion_proveedor")))
                                {
                                    comboBox_localidad.Items.Add(reader.GetString("Localidad_Direccion_proveedor"));
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }

                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query2, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Verificar si el valor no es null antes de agregarlo al ComboBox
                                if (!reader.IsDBNull(reader.GetOrdinal("Nombre_proveedor")))
                                {
                                    textBox_nombre_prov.Text=(reader.GetString("Nombre_proveedor"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Nro_Direccion_proveedor")))
                                {
                                    maskedTextBox_nro.Text = (reader.GetInt32("Nro_Direccion_proveedor")).ToString();
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Calle_Direccion_proveedor")))
                                {
                                    textBox_calle.Text = (reader.GetString("Calle_Direccion_proveedor"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Localidad_Direccion_proveedor")))
                                {
                                    comboBox_localidad.Text = (reader.GetString("Localidad_Direccion_proveedor"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Mail_proveedor")))
                                {
                                    textBox_mail.Text = (reader.GetString("Mail_proveedor"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Telefono_proveedor")))
                                {
                                    long telefonoProveedor = reader.GetInt64(reader.GetOrdinal("Telefono_proveedor"));
                                    textBox_telefono.Text = telefonoProveedor.ToString();
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
            comboBox_localidad.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_localidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_localidad.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {

            if (textBox_nombre_prov.Text.Length == 0)
            {
                MessageBox.Show("Falta agregar nombre de proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // for Error 
            }
            else
            {

                string nombre_provedor = textBox_nombre_prov.Text;
                string calle_proveedor = textBox_calle.Text;
                int nro_proveedor = int.Parse(maskedTextBox_nro.Text);
                string mail_proveedor = textBox_mail.Text;
                string telefono_proveedor = textBox_telefono.Text;
                string localidad_proveedor = comboBox_localidad.Text;
                string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Insertar el nuevo equipo


                        string insertar_proveedor_Query = "UPDATE proveedor SET Nombre_proveedor = @Nombre_proveedor," +
                        "Nro_Direccion_proveedor = @Nro_Direccion_proveedor, Calle_Direccion_proveedor = @Calle_Direccion_proveedor," +
                        "Localidad_Direccion_proveedor = @Localidad_Direccion_proveedor, Mail_proveedor = @Mail_proveedor, " +
                        "Telefono_proveedor = @Telefono_proveedor WHERE Id_proveedor = " + ID.ToString();
                        using (MySqlCommand insertar_proveedor_Command = new MySqlCommand(insertar_proveedor_Query, connection))
                        {
                            insertar_proveedor_Command.Parameters.AddWithValue("@Nombre_proveedor", nombre_provedor);
                            if (nro_proveedor != 0)
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Nro_Direccion_proveedor", nro_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Nro_Direccion_proveedor", DBNull.Value);

                            }
                            if (calle_proveedor.Length != 0)
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Calle_Direccion_proveedor", calle_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Calle_Direccion_proveedor", DBNull.Value);
                            }
                            if (localidad_proveedor.Length != 0)
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Localidad_Direccion_proveedor", localidad_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Localidad_Direccion_proveedor", DBNull.Value);

                            }
                            if (mail_proveedor.Length!=0)
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Mail_proveedor", mail_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Mail_proveedor", DBNull.Value);
                            }

                            if (telefono_proveedor.Length!=0)
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Telefono_proveedor", telefono_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_Command.Parameters.AddWithValue("@Telefono_proveedor", DBNull.Value);
                            }


                            insertar_proveedor_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Proveedor modificado exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el proveedor: " + ex.Message);
                    }
                }
            }
        }
    }
    
}
