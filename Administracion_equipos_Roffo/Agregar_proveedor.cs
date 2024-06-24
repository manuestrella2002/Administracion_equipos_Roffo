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
    public partial class Agregar_proveedor : Form
    {
        public Agregar_proveedor(string nombre_prov)
        {
            InitializeComponent();
            LoadComboBoxData();
            textBox_nombre_prov.Text = nombre_prov;

        }
        public Agregar_proveedor()
        {
            InitializeComponent();
            LoadComboBoxData();
           

        }

        private void LoadComboBoxData()
        {
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";
            string query1 = "SELECT DISTINCT Localidad_Direccion_proveedor FROM proveedor";

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
                int nro_proveedor =int.Parse(maskedTextBox_nro.Text);
                string mail_proveedor = textBox_mail.Text;
                string telefono_proveedor = textBox_telefono.Text;
                string localidad_proveedor = comboBox_localidad.Text;

                string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string query = "INSERT INTO proveedor (Nombre_proveedor,Nro_Direccion_proveedor,Calle_Direccion_proveedor,Localidad_Direccion_proveedor,Mail_proveedor,Telefono_proveedor) VALUES (@Nombre_proveedor,@Nro_Direccion_proveedor,@Calle_Direccion_proveedor,@Localidad_Direccion_proveedor,@Mail_proveedor,@Telefono_proveedor)";
                        using (MySqlCommand insertar_proveedor_command = new MySqlCommand(query, connection))
                        {
                            insertar_proveedor_command.Parameters.AddWithValue("@Nombre_proveedor",nombre_provedor);
                            if (calle_proveedor.Length!=0)
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Calle_Direccion_proveedor", calle_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Calle_Direccion_proveedor", DBNull.Value);

                            }
                            if (nro_proveedor.ToString().Length != 0)
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Nro_Direccion_proveedor", nro_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Nro_Direccion_proveedor", DBNull.Value);

                            }
                            if (localidad_proveedor.Length != 0)
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Localidad_Direccion_proveedor", localidad_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Localidad_Direccion_proveedor", DBNull.Value);

                            }
                            if (telefono_proveedor.ToString().Length != 0)
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Telefono_proveedor", telefono_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Telefono_proveedor", DBNull.Value);

                            }
                            if (mail_proveedor.Length != 0)
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Mail_proveedor", mail_proveedor);
                            }
                            else
                            {
                                insertar_proveedor_command.Parameters.AddWithValue("@Mail_proveedor", DBNull.Value);

                            }
                            insertar_proveedor_command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Proveedor guardado exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al guardar proveedor: " + ex.Message);
                    }
                    

                }


            }
        }

        private void button_cancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Esta seguro que quiere cancelar ?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
