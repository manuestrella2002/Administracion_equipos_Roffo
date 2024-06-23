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
    public partial class Agregar_parte : Form
    {
        public Agregar_parte()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";
            string query1 = "SELECT DISTINCT Marca_parte FROM inventario";
            string query2 = "SELECT DISTINCT Nombre_proveedor FROM proveedor";

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
                                if (!reader.IsDBNull(reader.GetOrdinal("Marca_parte")))
                                {
                                    comboBox_marca.Items.Add(reader.GetString("Marca_parte"));
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
                                if (!reader.IsDBNull(reader.GetOrdinal("Nombre_proveedor")))
                                {
                                    comboBox_proveedor.Items.Add(reader.GetString("Nombre_proveedor"));
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
            comboBox_proveedor.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_proveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_proveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_guardar_parte_Click(object sender, EventArgs e)
        {
            if (textBox_nombre_parte.Text.Length == 0)
            {
                MessageBox.Show("Falta agregar nombre de parte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // for Error 
            }
            else if(contador_cantidad.Value==0)
            {
                MessageBox.Show("Falta agregar cantidad de parte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // for Error 

            }
            else
            {
                string nombre_parte = textBox_nombre_parte.Text;
                string marca_parte = comboBox_marca.Text;
                int cantidad = Convert.ToInt32(contador_cantidad.Value);
                string descripcion = textBox_descripcion.Text;
                string id_proveedor=null;

                string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    if (comboBox_proveedor.Text.Length != 0)
                    {
                        try
                        {
                            string query = "SELECT DISTINCT Id_proveedor FROM proveedor WHERE Nombre_proveedor = '" + comboBox_proveedor.Text+"'";
                            using (MySqlCommand buscar_proveedor_command = new MySqlCommand(query,connection))
                            {
                                using (MySqlDataReader reader = buscar_proveedor_command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        if (!reader.IsDBNull(reader.GetOrdinal("Id_proveedor")))
                                        {
                                            id_proveedor = reader.GetString("Id_proveedor");
                                        }
                                    }

                                }
                            }

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al recuperar id de proveedor: " + ex.Message);
                        }
                    }
                    else
                    {
                        id_proveedor = null;
                    }


                    try
                    {
                        // Insertar el nuevo equipo


                        string insertar_parte_Query = "INSERT INTO inventario (Nombre_parte,Marca_parte,Cantidad_disponible,Descripcion,proveedor_Id_proveedor) VALUES (@Nombre_parte,@Marca_parte,@Cantidad_disponible,@Descripcion,@proveedor_Id_proveedor)";
                        using (MySqlCommand insertar_parte_Command = new MySqlCommand(insertar_parte_Query, connection))
                        {
                            insertar_parte_Command.Parameters.AddWithValue("@nombre_parte", nombre_parte);
                            insertar_parte_Command.Parameters.AddWithValue("@Cantidad_disponible", cantidad);
                            if (marca_parte.Length != 0)
                            {
                                insertar_parte_Command.Parameters.AddWithValue("@Marca_parte", marca_parte);
                            }
                            else
                            {
                                insertar_parte_Command.Parameters.AddWithValue("@Marca_parte", DBNull.Value);

                            }
                            if (descripcion.Length!=0)
                            {
                                insertar_parte_Command.Parameters.AddWithValue("@Descripcion", descripcion);
                            }
                            else
                            {
                                insertar_parte_Command.Parameters.AddWithValue("@Descripcion", DBNull.Value);
                            }

                            if (id_proveedor==null)
                            {
                                insertar_parte_Command.Parameters.AddWithValue("@proveedor_Id_proveedor", DBNull.Value);

                            }
                            else if ( id_proveedor.Length!=0)
                            {
                                insertar_parte_Command.Parameters.AddWithValue("@proveedor_Id_proveedor",int.Parse(id_proveedor));

                            }
                            
                            insertar_parte_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Parte creada exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear la parte: " + ex.Message);
                    }
                }
            }
        }
    }
    
}
