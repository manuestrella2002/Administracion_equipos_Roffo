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
    public partial class Actualizar_orden : Form
    {

        private int ID;
        public Actualizar_orden(int id_orden_de_trabajo)
        {
            InitializeComponent();
            ID = id_orden_de_trabajo;
        }

        

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Esta seguro que cancelar la actualización de la orden?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (textBox_descripcion.Text.Length != 0)
            {
                string descripcion = textBox_descripcion.Text;
               

                string connectionString = "server=10.0.0.176;database=db_roffo;uid=remote_user;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Insertar el nuevo equipo


                        string insertar_equipo_Query = "INSERT INTO actualizacion_ordenes_de_trabajo (Descripcion,Fecha_actualizacion,Id_orden_de_trabajo) VALUES (@Descripcion, NOW(), @Id_orden_de_trabajo)";
                        using (MySqlCommand insertar_equipo_Command = new MySqlCommand(insertar_equipo_Query, connection))
                        {
                            insertar_equipo_Command.Parameters.AddWithValue("@Descripcion", descripcion);
                            insertar_equipo_Command.Parameters.AddWithValue("@Id_orden_de_trabajo", ID);
                            
                            insertar_equipo_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Actualizacion de orden guardada exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar actualizacion de orden: " + ex.Message);
                    }
                }
            }

        }
    }
}

