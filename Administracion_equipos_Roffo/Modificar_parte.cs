﻿using MySql.Data.MySqlClient;
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
    public partial class Modificar_parte : Form
    {
        private int ID; 
        public Modificar_parte(int id_parte)
        {
            InitializeComponent();
            LoadComboBoxData(id_parte);
            ID = id_parte;
        }
        private void LoadComboBoxData(int id_parte)
        {
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";
            string query1 = "SELECT DISTINCT Marca_parte FROM inventario";

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


            }

            // Permitir que el ComboBox acepte texto no listado
            comboBox_marca.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_marca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_marca.AutoCompleteSource = AutoCompleteSource.ListItems;
            
             string query2 = "SELECT * FROM inventario WHERE Id_parte = "+id_parte.ToString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query2, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("Nombre_parte")))
                                {
                                    textBox_nombre_parte.Text = (reader.GetString("Nombre_parte"));
                                }
                                // Verificar si el valor no es null antes de agregarlo al ComboBox
                                if (!reader.IsDBNull(reader.GetOrdinal("Marca_parte")))
                                {
                                    comboBox_marca.Text=(reader.GetString("Marca_parte"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Cantidad_disponible")))
                                {
                                    contador_cantidad.Value = (reader.GetInt32("Cantidad_disponible"));
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("Descripcion")))
                                {
                                    textBox_descripcion.Text = (reader.GetString("Descripcion"));
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
        }


        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Esta seguro que quiere cancelar la modificacion de la parte?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_modificar_parte_Click(object sender, EventArgs e)
        {
            if (textBox_nombre_parte.Text.Length == 0)
            {
                MessageBox.Show("Falta agregar nombre de parte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // for Error 
            }
            else if (contador_cantidad.Value == 0)
            {
                MessageBox.Show("Falta agregar cantidad de parte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // for Error 

            }
            else
            {
                string nombre_parte = textBox_nombre_parte.Text;
                string marca_parte = comboBox_marca.Text;
                int cantidad = Convert.ToInt32(contador_cantidad.Value);
                string descripcion = textBox_descripcion.Text;
                string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";



                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    try
                    {
                        // Insertar el nuevo equipo


                        string insertar_parte_Query = "UPDATE inventario SET Nombre_parte=@Nombre_parte,Marca_parte=@Marca_parte,Cantidad_disponible=@Cantidad_disponible,Descripcion=@Descripcion,proveedor_Id_proveedor=@proveedor_Id_proveedor WHERE Id_parte = "+ ID.ToString();
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
                            if (descripcion.Length != 0)
                            {
                                insertar_parte_Command.Parameters.AddWithValue("@Descripcion", descripcion);
                            }
                            else
                            {
                                insertar_parte_Command.Parameters.AddWithValue("@Descripcion", DBNull.Value);
                            }



                            insertar_parte_Command.Parameters.AddWithValue("@proveedor_Id_proveedor", DBNull.Value);


                            insertar_parte_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Parte modificada exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar la parte: " + ex.Message);
                    }
                }
            }
        }
    }
}
