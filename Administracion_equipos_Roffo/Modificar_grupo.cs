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
    public partial class Modificar_grupo : Form
    {
        private int ID;
        public Modificar_grupo(int id_grupo)
        {
            InitializeComponent();
            Mostrar_detalles(id_grupo);
            ID = id_grupo;
        }

        private void Mostrar_detalles(int Id_grupo)
        {
            string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

            // Define tu consulta SQL
            string id_grupo_string = Id_grupo.ToString();
            string query = "SELECT * FROM grupo_electrogeno WHERE Id_grupo =" + id_grupo_string;

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
                                textBox_nombre_grupo.Text = reader["Nombre_grupo"].ToString();
                                comboBox_combustible.Text = reader["Combustible_grupo"].ToString();
                                comboBox_estado.Text = reader["Status_grupo"].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos del equipo: " + ex.Message);
                }


            }

            comboBox_combustible.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_estado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_guardar_cambios_Click(object sender, EventArgs e)
        {
            string combustible = comboBox_combustible.Text;
            string estado = comboBox_estado.Text;

            string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar el nuevo equipo


                    string insertar_orden_Query = "UPDATE grupo_electrogeno SET Combustible_grupo=@Combustible, Status_grupo=@Estado WHERE Id_grupo=" + ID.ToString();
                    using (MySqlCommand insertar_orden_Command = new MySqlCommand(insertar_orden_Query, connection))
                    {
                        insertar_orden_Command.Parameters.AddWithValue("@Combustible", combustible);
                        insertar_orden_Command.Parameters.AddWithValue("@Estado", estado);
                        insertar_orden_Command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Grupo modificado exitosamente.", "Mensaje", MessageBoxButtons.OK);
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el grupo: " + ex.Message);
                }
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Esta seguro que quiere cancelar la modificacion del grupo electrogeno?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
