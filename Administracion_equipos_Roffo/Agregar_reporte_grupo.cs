using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Administracion_equipos_Roffo
{
    public partial class Agregar_reporte_grupo : Form
    {
        public Agregar_reporte_grupo()
        {
            InitializeComponent();
            Agregar_controles();
        }

        private void Agregar_controles()
        {
            //PANEL ACEITE RESONADOR
            {
                panel_aceite_resonador.Controls.Add(radioButton_aceite_ok_reso);
                panel_aceite_resonador.Controls.Add(radioButton_aceite_ok_osc_reso);
                panel_aceite_resonador.Controls.Add(radioButton_aceite_mal_reso);
            }
            //PANEL ACEITE ULTRAFREZEERS
            {
                panel_aceite_ultrafrezeers.Controls.Add(radioButton_aceite_ok_ultrafreezers);
                panel_aceite_ultrafrezeers.Controls.Add(radioButton_aceite_mal_ultrafrezeers);
                panel_aceite_ultrafrezeers.Controls.Add(radioButton_aceite_ok_osc_ultrafreezers);
            }
            //PANEL ACEITE PATOLOGIA
            {
                panel_aceite_patologia.Controls.Add(radioButton_aceite_ok_patologia);
                panel_aceite_patologia.Controls.Add(radioButton_aceite_ok_osc_patologia);
                panel_aceite_patologia.Controls.Add(radioButton_aceite_mal_patologia);
            }
            //PANEL ACEITE CIRUGIA
            {
                panel_aceite_cirugia.Controls.Add(radioButton_aceite_ok_cirugia);
                panel_aceite_cirugia.Controls.Add(radioButton_aceite_ok_osc_cirugia);
                panel_aceite_cirugia.Controls.Add(radioButton_aceite_mal_cirugia);
            }
            //PANEL ACEITE HEMOTERAPIA
            {
                panel_aceite_hemoterapia.Controls.Add(radioButton_aceite_ok_hemoterapia);
                panel_aceite_hemoterapia.Controls.Add(radioButton_aceite_ok_osc_hemoterapia);
                panel_aceite_hemoterapia.Controls.Add(radioButton_aceite_mal_hemoterapia);
            }
            //PANEL ACEITE UTI
            {
                panel_aceite_UTI.Controls.Add(radioButton_aceite_ok_uti);
                panel_aceite_UTI.Controls.Add(radioButton_aceite_ok_osc_UTI);
                panel_aceite_UTI.Controls.Add(radioButton_aceite_mal_UTI);
            }
            //PANEL ACEITE BIOTERIO
            {
                panel_aceite_bioterio.Controls.Add(radioButton_aceite_ok_bioterio);
                panel_aceite_bioterio.Controls.Add(radioButton_aceite_ok_osc_bioterio);
                panel_aceite_bioterio.Controls.Add(radioButton_aceite_mal_bioterio);
            }



            //PANEL REFRIGERANTE RESONADOR
            {
                panel_refri_resonador.Controls.Add(radiobutton_Refri_ok_resonador);
                panel_refri_resonador.Controls.Add(radioButton_refri_mal_resonador);
            }
            //PANEL REFRIGERANTE ULTRAFREZEERS
            {
                panel_refri_ultrafrezeers.Controls.Add(radiobutton_Refri_ok_ultrafrezeers);
                panel_refri_ultrafrezeers.Controls.Add(radioButton_refri_mal_ultrafrezeers);
            }
            //PANEL REFRIGERANTE PATOLOGIA
            {
                panel_refri_patologia.Controls.Add(radiobutton_Refri_ok_patologia);
                panel_refri_patologia.Controls.Add(radioButton_refri_mal_patologia);
            }
            //PANEL REFRIGERANTE CIRUGIA
            {
                panel_refri_cirugia.Controls.Add(radiobutton_Refri_ok_cirugia);
                panel_refri_cirugia.Controls.Add(radioButton_refri_mal_cirugia);
            }
            //PANEL REFRIGERANTE HEMOTERAPIA
            {
                panel_refri_hemoterapia.Controls.Add(radiobutton_Refri_ok_hemoterapia);
                panel_refri_hemoterapia.Controls.Add(radioButton_refri_mal_hemoterapia);
            }
            //PANEL REFRIGERANTE UTI
            {
                panel_refri_UTI.Controls.Add(radiobutton_Refri_ok_UTI);
                panel_refri_UTI.Controls.Add(radioButton_refri_mal_UTI);
            }
            //PANEL REFRIGERANTE BIOTERIO
            {
                panel_refri_bioterio.Controls.Add(radiobutton_Refri_ok_bioterio);
                panel_refri_bioterio.Controls.Add(radioButton_refri_mal_bioterio);
            }



            //PANEL AGUA BATERIA HEMOTERAPIA
            {
                panel_agua_bat_hemoterapia.Controls.Add(radioButton_agua_bat_ok_hemoterapia);
                panel_agua_bat_hemoterapia.Controls.Add(radioButton_agua_bat_bajo_hemoterapia);
            }
            //PANEL AGUA BATERIA UTI
            {
                panel_agua_bat_UTI.Controls.Add(radioButton_agua_bat_ok_UTI);
                panel_agua_bat_UTI.Controls.Add(radioButton_agua_bat_bajo_UTI);
            }

        }

        private bool Chequeo()
        {
            // NIVEL ACEITE
            if (radioButton_aceite_mal_reso.Checked == false && radioButton_aceite_ok_reso.Checked == false && radioButton_aceite_ok_osc_reso.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite resonador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radioButton_aceite_mal_ultrafrezeers.Checked == false && radioButton_aceite_ok_ultrafreezers.Checked == false && radioButton_aceite_ok_osc_ultrafreezers.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite ultrafrezeers", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radioButton_aceite_mal_patologia.Checked == false && radioButton_aceite_ok_patologia.Checked == false && radioButton_aceite_ok_osc_patologia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite patologia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radioButton_aceite_mal_cirugia.Checked == false && radioButton_aceite_ok_cirugia.Checked == false && radioButton_aceite_ok_osc_cirugia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite cirugia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radioButton_aceite_mal_hemoterapia.Checked == false && radioButton_aceite_ok_hemoterapia.Checked == false && radioButton_aceite_ok_osc_hemoterapia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite hemoterapia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radioButton_aceite_mal_UTI.Checked == false && radioButton_aceite_ok_uti.Checked == false && radioButton_aceite_ok_osc_UTI.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite UTI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radioButton_aceite_mal_bioterio.Checked == false && radioButton_aceite_ok_bioterio.Checked == false && radioButton_aceite_ok_osc_bioterio.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite bioterio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // NIVEL REFRIGERANTE
            if (radiobutton_Refri_ok_resonador.Checked == false && radioButton_refri_mal_resonador.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante resonador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radiobutton_Refri_ok_ultrafrezeers.Checked == false && radioButton_refri_mal_ultrafrezeers.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante ultrafrezeers", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radiobutton_Refri_ok_patologia.Checked == false && radioButton_refri_mal_patologia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante patologia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radiobutton_Refri_ok_cirugia.Checked == false && radioButton_refri_mal_cirugia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante cirugia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radiobutton_Refri_ok_hemoterapia.Checked == false && radioButton_refri_mal_hemoterapia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante hemoterapia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radiobutton_Refri_ok_UTI.Checked == false && radioButton_refri_mal_UTI.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante UTI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radiobutton_Refri_ok_bioterio.Checked == false && radioButton_refri_mal_bioterio.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante bioterio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // NIVEL AGUA BATERIA
            if (radioButton_agua_bat_ok_hemoterapia.Checked == false && radioButton_agua_bat_bajo_hemoterapia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel agua bateria hemoterapia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radioButton_agua_bat_ok_UTI.Checked == false && radioButton_agua_bat_bajo_UTI.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel agua bateria UTI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            // ESTADO
            if (comboBox_estado_reso.SelectedIndex == -1)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar estado de resonador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox_estado_ultrafrezzers.SelectedIndex == -1)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar estado de ultrafrezeers", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox_estado_patologia.SelectedIndex == -1)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar estado de patolgia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox_estado_cirugia.SelectedIndex == -1)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar estado de cirugia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox_estado_hemoterapia.SelectedIndex == -1)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar estado de hemoterapia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox_estado_UTI.SelectedIndex == -1)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar estado de UTI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox_estado_bioterio.SelectedIndex == -1)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar estado de bioterio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Esta seguro que quiere cancelar el reporte?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void numericUpDown76_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_guardar_reporte_Click(object sender, EventArgs e)
        {
            string nivel_aceite_resonador;
            string nivel_aceite_ultrafrezeers;
            string nivel_aceite_patologia;
            string nivel_aceite_hemoterapia;
            string nivel_aceite_cirugia;
            string nivel_aceite_UTI;
            string nivel_aceite_bioterio;


            string nivel_refri_resonador;
            string nivel_refri_ultrafrezeers;
            string nivel_refri_patologia;
            string nivel_refri_hemoterapia;
            string nivel_refri_cirugia;
            string nivel_refri_UTI;
            string nivel_refri_bioterio;

            int nivel_comb_resonador = Convert.ToInt32(numeric_comb_resonador.Value);
            int nivel_comb_ultrafrezeers = Convert.ToInt32(numeric_comb_ultrafrezeers.Value);
            int nivel_comb_patologia = Convert.ToInt32(numeric_comb_patologia.Value);
            int nivel_comb_hemoterapia = Convert.ToInt32(numeric_comb_hemoterapia.Value);
            int nivel_comb_cirugia = Convert.ToInt32(numeric_comb_cirugia.Value);
            int nivel_comb_UTI = Convert.ToInt32(numeric_comb_UTI.Value);
            int nivel_comb_bioterio = Convert.ToInt32(numeric_comb_bioterio.Value);


            string nivel_agua_hemoterapia;
            string nivel_agua_UTI;

            int bat_carga_resonador = Convert.ToInt32(numeric_U_bat_carga_resonador.Value);
            int bat_carga_ultrafrezeers = Convert.ToInt32(numeric_U_bat_carga_ultrafrezeers.Value);
            int bat_carga_patologia = Convert.ToInt32(numeric_U_bat_carga_patologia.Value);
            int bat_carga_hemoterapia = Convert.ToInt32(numeric_U_bat_carga_hemoterapia.Value);
            int bat_carga_cirugia = Convert.ToInt32(numeric_U_bat_carga_cirugia.Value);
            int bat_carga_UTI = Convert.ToInt32(numeric_U_bat_carga_UTI.Value);
            int bat_carga_bioterio = Convert.ToInt32(numeric_U_bat_carga_bioterio.Value);


            int bat_reposo_resonador = Convert.ToInt32(numeric_U_bat_rep_resonador.Value);
            int bat_reposo_ultrafrezeers = Convert.ToInt32(numeric_U_bat_rep_ultrafrezeers.Value);
            int bat_reposo_patologia = Convert.ToInt32(numeric_U_bat_rep_patologia.Value);
            int bat_reposo_hemoterapia = Convert.ToInt32(numeric_U_bat_rep_hemoterapia.Value);
            int bat_reposo_cirugia = Convert.ToInt32(numeric_U_bat_rep_cirugia.Value);
            int bat_reposo_UTI = Convert.ToInt32(numeric_U_bat_rep_UTI.Value);
            int bat_reposo_bioterio = Convert.ToInt32(numeric_U_bat_rep_bioterio.Value);

            //if (Chequeo())
            if (true)
            {
                foreach (var control in panel_aceite_resonador.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_aceite_resonador = radioButton.Text;
                    }
                }
                foreach (var control in panel_aceite_ultrafrezeers.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_aceite_ultrafrezeers = radioButton.Text;
                    }
                }
                foreach (var control in panel_aceite_patologia.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_aceite_patologia = radioButton.Text;
                    }
                }
                foreach (var control in panel_aceite_hemoterapia.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_aceite_hemoterapia = radioButton.Text;
                    }
                }
                foreach (var control in panel_aceite_cirugia.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_aceite_cirugia = radioButton.Text;
                    }
                }
                foreach (var control in panel_aceite_UTI.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_aceite_UTI = radioButton.Text;
                    }
                }
                foreach (var control in panel_aceite_bioterio.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_aceite_bioterio = radioButton.Text;
                    }
                }


                foreach (var control in panel_refri_resonador.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_refri_resonador = radioButton.Text;
                    }
                }
                foreach (var control in panel_refri_ultrafrezeers.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_refri_ultrafrezeers = radioButton.Text;
                    }
                }
                foreach (var control in panel_refri_patologia.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_refri_patologia = radioButton.Text;
                    }
                }
                foreach (var control in panel_refri_hemoterapia.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_refri_hemoterapia = radioButton.Text;
                    }
                }
                foreach (var control in panel_refri_cirugia.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_refri_cirugia = radioButton.Text;
                    }
                }
                foreach (var control in panel_refri_UTI.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_refri_UTI = radioButton.Text;
                    }
                }
                foreach (var control in panel_refri_bioterio.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_refri_bioterio = radioButton.Text;
                    }
                }


                foreach (var control in panel_agua_bat_hemoterapia.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_agua_hemoterapia = radioButton.Text;
                    }
                }
                foreach (var control in panel_agua_bat_UTI.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        nivel_agua_UTI = radioButton.Text;
                    }
                }






                //string marca_equipo = comboBox_marca.Text;
                //string modelo_equipo = textBox_modelo_equipo.Text;
                //string nro_serie = textBox_nro_serie_equipo.Text;


                //DateTime Fecha_fab = dateTime_fecha_fab.Value;
                //string fechafabSQL = Fecha_fab.ToString("yyyy-MM-dd HH:mm:ss");



                //DateTime Fecha_adq = dateTime_fecha_adq.Value;
                //string fechaadqSQL = Fecha_adq.ToString("yyyy-MM-dd HH:mm:ss");

                //string ubicacion = comboBox_ubicacion.Text;
                //string estado = comboBox_estado.Text;

                //string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                //using (MySqlConnection connection = new MySqlConnection(connectionString))
                //{
                //    try
                //    {
                //        connection.Open();

                //        // Insertar el nuevo equipo


                //        string insertar_equipo_Query = "INSERT INTO equipo (Nombre_equipo,Modelo_equipo,Marca_equipo,Nro_serie_equipo,Fecha_fabricacion_equipo,Fecha_adquisicion_equipo,Ubicacion_equipo,Status_equipo) VALUES (@nombre_equipo,@modelo_equipo,@marca_equipo,@Nro_serie_equipo,@Fecha_fabricacion_equipo,@Fecha_adquisicion_equipo,@Ubicacion_equipo,@Status_equipo)";
                //        using (MySqlCommand insertar_equipo_Command = new MySqlCommand(insertar_equipo_Query, connection))
                //        {
                //            insertar_equipo_Command.Parameters.AddWithValue("@nombre_equipo", nombre_equipo);
                //            if (modelo_equipo.Length != 0)
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@modelo_equipo", modelo_equipo);
                //            }
                //            else
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@modelo_equipo", DBNull.Value);

                //            }
                //            if (marca_equipo.Length != 0)
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@marca_equipo", marca_equipo);
                //            }
                //            else
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@marca_equipo", DBNull.Value);
                //            }
                //            if (nro_serie.Length != 0)
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Nro_serie_equipo", nro_serie);
                //            }
                //            else
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Nro_serie_equipo", DBNull.Value);

                //            }
                //            if (dateTime_fecha_fab.Checked)
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Fecha_fabricacion_equipo", fechafabSQL);
                //            }
                //            else
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Fecha_fabricacion_equipo", DBNull.Value);
                //            }

                //            if (dateTime_fecha_adq.Checked)
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Fecha_adquisicion_equipo", fechaadqSQL);
                //            }
                //            else
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Fecha_adquisicion_equipo", DBNull.Value);
                //            }
                //            if (ubicacion.Length != 0)
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Ubicacion_equipo", ubicacion);
                //            }
                //            else
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Ubicacion_equipo", DBNull.Value);
                //            }
                //            if (estado.Length != 0)
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Status_equipo", estado);
                //            }
                //            else
                //            {
                //                insertar_equipo_Command.Parameters.AddWithValue("@Status_equipo", DBNull.Value);

                //            }
                //            insertar_equipo_Command.ExecuteNonQuery();
                //        }

                //        MessageBox.Show("Equipo guardado exitosamente.", "Mensaje", MessageBoxButtons.OK);
                //        this.Close();


                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Error al guardar el equipo: " + ex.Message);
                //    }
                //}
            }
        }


    }
}
