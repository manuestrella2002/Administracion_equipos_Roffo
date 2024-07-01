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
    public partial class Agregar_reporte_equipo : Form
    {
        private int ID;
        public Agregar_reporte_equipo(int id_equipo)
        {
            InitializeComponent();
            ID = id_equipo;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (textBox_descripcion.Text.Length != 0)
            {
                string descripcion = textBox_descripcion.Text;

                string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Insertar el nuevo equipo


                        string insertar_reporte_equipo_Query = "INSERT INTO reporte_equipo (Descripcion,Fecha,equipo_Id_equipo) VALUES (@Descripcion,NOW(),@equipo_Id_equipo)";
                        using (MySqlCommand insertar_reporte_equipo_Command = new MySqlCommand(insertar_reporte_equipo_Query, connection))
                        {
                            insertar_reporte_equipo_Command.Parameters.AddWithValue("@Descripcion", descripcion);
                            insertar_reporte_equipo_Command.Parameters.AddWithValue("@equipo_Id_equipo", ID);
                            insertar_reporte_equipo_Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Reporte de equipo creado exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear reporte de equipo: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe agregar una descripcion.", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }
    }
}
