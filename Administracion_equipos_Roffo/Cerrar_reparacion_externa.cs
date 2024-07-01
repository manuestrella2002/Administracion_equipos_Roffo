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
    public partial class Cerrar_reparacion_externa : Form
    {
        private int ID;
        public Cerrar_reparacion_externa(int id_reparacion)
        {
            InitializeComponent();
            ID = id_reparacion;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_marcar_regreso_Click(object sender, EventArgs e)
        {
            if (textBox_reporte_proveedor.Text.Length != 0)
            {
                string reporte = textBox_reporte_proveedor.Text;
                string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Insertar el nuevo equipo


                        string insertar_rep_ext_Query = "UPDATE reparacion_externa SET Fecha_reentrada = NOW() , reporte_proovedor = @reporte_proovedor" +
                            " WHERE Id_reparacion_externa = " + ID.ToString();
                        using (MySqlCommand insertar_rep_ext_Command = new MySqlCommand(insertar_rep_ext_Query, connection))
                        {

                            insertar_rep_ext_Command.Parameters.AddWithValue("@reporte_proovedor", reporte);
                            insertar_rep_ext_Command.ExecuteNonQuery();
                        }
                        

                        MessageBox.Show("Reparacion externa cerrada exitosamente.", "Mensaje", MessageBoxButtons.OK);
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cerrar reparacion externa: " + ex.Message);
                    }
                }
            }

            else
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Debe completar el reporte del proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
   