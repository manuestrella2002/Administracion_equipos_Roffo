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

            if (numeric_hora_resonador.Text.Length == 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta hora de resonador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numeric_hora_ultrafrezeers.Text.Length == 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta hora de ultrafrezeers", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numeric_hora_patologia.Text.Length == 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta hora de patologia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numeric_hora_cirugia.Text.Length == 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta hora de cirugia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numeric_hora_UTI.Text.Length == 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta hora de UTI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numeric_hora_bioterio.Text.Length == 0)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta hora de bioterio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (Chequeo())
            {


                string nivel_aceite_resonador = "";
                string nivel_aceite_ultrafrezeers = "";
                string nivel_aceite_patologia = "";
                string nivel_aceite_hemoterapia = "";
                string nivel_aceite_cirugia = "";
                string nivel_aceite_UTI = "";
                string nivel_aceite_bioterio = "";


                string nivel_refri_resonador = "";
                string nivel_refri_ultrafrezeers = "";
                string nivel_refri_patologia = "";
                string nivel_refri_hemoterapia = "";
                string nivel_refri_cirugia = "";
                string nivel_refri_UTI = "";
                string nivel_refri_bioterio = "";

                int nivel_comb_resonador = Convert.ToInt32(num_comb_resonador.Value);
                int nivel_comb_ultrafrezeers = Convert.ToInt32(num_comb_ultrafrezeers.Value);
                int nivel_comb_patologia = Convert.ToInt32(num_comb_patologia.Value);
                int nivel_comb_hemoterapia = Convert.ToInt32(num_comb_hemoterapia.Value);
                int nivel_comb_cirugia = Convert.ToInt32(num_comb_cirugia.Value);
                int nivel_comb_UTI = Convert.ToInt32(num_comb_UTI.Value);
                int nivel_comb_bioterio = Convert.ToInt32(num_comb_bioterio.Value);


                string nivel_agua_hemoterapia = "";
                string nivel_agua_UTI = "";

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

                int rpm_resonador = Convert.ToInt32(numeric_rpm_resonador.Value);
                int rpm_ultrafreezers = Convert.ToInt32(numeric_rpm_ultrafrezeers.Value);
                int rpm_patologia = Convert.ToInt32(numeric_rpm_patologia.Value);
                int rpm_cirugia = Convert.ToInt32(numeric_rpm_cirugia.Value);
                int rpm_bioterio = Convert.ToInt32(numeric_rpm_bioterio.Value);

                decimal frec_hz_resonador = numeric_frec_resonador.Value;
                decimal frec_hz_ultrafreezers = numeric_frec_ultrafrezeers.Value;
                decimal frec_hz_patologia = numeric_frec_patologia.Value;
                decimal frec_hz_hemoterapia = numeric_frec_hemoterapia.Value;
                decimal frec_hz_cirugia = numeric_frec_cirugia.Value;
                decimal frec_hz_UTI = numeric_frec_UTI.Value;
                decimal frec_hz_bioterio = numeric_frec_bioterio.Value;

                int nro_arranque_resonador = Convert.ToInt32(numeric_nro_arranques_resonador.Value);
                int nro_arranque_ultrafreezers = Convert.ToInt32(numeric_nro_arranques_ultrafrezeers.Value);
                int nro_arranque_patologia = Convert.ToInt32(numeric_nro_arranques_patologia.Value);
                int nro_arranque_cirugia = Convert.ToInt32(numeric_nro_arranques_cirugia.Value);
                int nro_arranque_UTI = Convert.ToInt32(numeric_nro_arranques_UTI.Value);
                int nro_arranque_bioterio = Convert.ToInt32(numeric_nro_arranques_bioterio.Value);



                decimal temperatura_resonador = numeric_Temperatura_resonador.Value;
                decimal temperatura_ultrafreezers = numeric_Temperatura_ultrafrezeers.Value;
                decimal temperatura_patologia = numeric_Temperatura_patologia.Value;
                decimal temperatura_hemoterapia = numeric_Temperatura_hemoterapia.Value;
                decimal temperatura_cirugia = numeric_Temperatura_cirugia.Value;
                decimal temperatura_UTI = numeric_Temperatura_UTI.Value;
                decimal temperatura_bioterio = numeric_Temperatura_bioterio.Value;

                decimal presion_resonador = numeric_presion_resonador.Value;
                decimal presion_ultrafreezers = numeric_presion_ultrafrezeers.Value;
                decimal presion_patologia = numeric_presion_patologia.Value;
                decimal presion_hemoterapia = numeric_presion_hemoterapia.Value;
                decimal presion_cirugia = numeric_presion_cirugia.Value;
                decimal presion_UTI = numeric_presion_UTI.Value;
                decimal presion_bioterio = numeric_presion_bioterio.Value;


                string estado_resonador = comboBox_estado_reso.Text;
                string estado_ultrafreezers = comboBox_estado_ultrafrezzers.Text;
                string estado_patologia = comboBox_estado_patologia.Text;
                string estado_hemoterapia = comboBox_estado_hemoterapia.Text;
                string estado_cirugia = comboBox_estado_cirugia.Text;
                string estado_UTI = comboBox_estado_UTI.Text;
                string estado_bioterio = comboBox_estado_bioterio.Text;

                // Variables para el grupo electrógeno del resonador
                int I_ent_R_resonador = Convert.ToInt32(numeric_I_ent_R_resonador.Value);
                int U_ent_R_resonador = Convert.ToInt32(numeric_U_ent_R_resonador.Value);
                int I_ent_S_resonador = Convert.ToInt32(numeric_I_ent_S_resonador.Value);
                int U_ent_S_resonador = Convert.ToInt32(numeric_U_ent_S_resonador.Value);
                int I_ent_T_resonador = Convert.ToInt32(numeric_I_ent_T_resonador.Value);
                int U_ent_T_resonador = Convert.ToInt32(numeric_U_ent_T_resonador.Value);
                int I_gen_R_resonador = Convert.ToInt32(numeric_I_gen_R_resonador.Value);
                int U_gen_R_resonador = Convert.ToInt32(numeric_U_gen_R_resonador.Value);
                int I_gen_S_resonador = Convert.ToInt32(numeric_I_gen_S_resonador.Value);
                int U_gen_S_resonador = Convert.ToInt32(numeric_U_gen_S_resonador.Value);
                int I_gen_T_resonador = Convert.ToInt32(numeric_I_gen_T_resonador.Value);
                int U_gen_T_resonador = Convert.ToInt32(numeric_U_gen_T_resonador.Value);

                // Variables para el grupo electrógeno de ultrafreezers
                int I_ent_R_ultrafreezers = Convert.ToInt32(numeric_I_ent_R_ultrafrezeers.Value);
                int U_ent_R_ultrafreezers = Convert.ToInt32(numeric_U_ent_R_Ultrafrezeers.Value);
                int I_ent_S_ultrafreezers = Convert.ToInt32(numeric_I_ent_S_ultrafrezeers.Value);
                int U_ent_S_ultrafreezers = Convert.ToInt32(numeric_U_ent_S_ultrafrezeers.Value);
                int I_ent_T_ultrafreezers = Convert.ToInt32(numeric_I_ent_T_ultrafrezeers.Value);
                int U_ent_T_ultrafreezers = Convert.ToInt32(numeric_U_ent_T_utrafrezeers.Value);
                int I_gen_R_ultrafreezers = Convert.ToInt32(numeric_I_gen_R_ultrafrezeers.Value);
                int U_gen_R_ultrafreezers = Convert.ToInt32(numeric_U_gen_R_ultrafrezeers.Value);
                int I_gen_S_ultrafreezers = Convert.ToInt32(numeric_I_gen_S_ultrafrezeers.Value);
                int U_gen_S_ultrafreezers = Convert.ToInt32(numeric_U_gen_S_ultrafrezeers.Value);
                int I_gen_T_ultrafreezers = Convert.ToInt32(numeric_I_gen_T_ultrafrezeers.Value);
                int U_gen_T_ultrafreezers = Convert.ToInt32(numeric_U_gen_T_ultrafrezeers.Value);

                // Variables para el grupo electrógeno de patología
                int I_ent_R_patologia = Convert.ToInt32(numeric_I_ent_R_patologia.Value);
                int U_ent_R_patologia = Convert.ToInt32(numeric_U_ent_R_patologia.Value);
                int I_ent_S_patologia = Convert.ToInt32(numeric_I_ent_S_patologia.Value);
                int U_ent_S_patologia = Convert.ToInt32(numeric_U_ent_S_patologia.Value);
                int I_ent_T_patologia = Convert.ToInt32(numeric_I_ent_T_patologia.Value);
                int U_ent_T_patologia = Convert.ToInt32(numeric_U_ent_T_patologia.Value);
                int I_gen_R_patologia = Convert.ToInt32(numeric_I_gen_R_patologia.Value);
                int U_gen_R_patologia = Convert.ToInt32(numeric_U_gen_R_patologia.Value);
                int I_gen_S_patologia = Convert.ToInt32(numeric_I_gen_S_patologia.Value);
                int U_gen_S_patologia = Convert.ToInt32(numeric_U_gen_S_patologia.Value);
                int I_gen_T_patologia = Convert.ToInt32(numeric_I_gen_T_patologia.Value);
                int U_gen_T_patologia = Convert.ToInt32(numeric_U_gen_T_patologia.Value);

                // Variables para el grupo electrógeno de hemoterapia
                int I_ent_R_hemoterapia = Convert.ToInt32(numeric_I_ent_R_hemoterapia.Value);
                int I_ent_S_hemoterapia = Convert.ToInt32(numeric_I_ent_S_hemoterapia.Value);
                int I_ent_T_hemoterapia = Convert.ToInt32(numeric_I_ent_T_hemoterapia.Value);
                int I_gen_R_hemoterapia = Convert.ToInt32(numeric_I_gen_R_hemoterapia.Value);
                int U_gen_R_hemoterapia = Convert.ToInt32(numeric_U_gen_R_hemoterapia.Value);
                int I_gen_S_hemoterapia = Convert.ToInt32(numeric_I_gen_S_hemoterapia.Value);
                int I_gen_T_hemoterapia = Convert.ToInt32(numeric_I_gen_T_hemoterapia.Value);

                // Variables para el grupo electrógeno de cirugía
                int I_ent_R_cirugia = Convert.ToInt32(numeric_I_ent_R_cirugia.Value);
                int U_ent_R_cirugia = Convert.ToInt32(numeric_U_ent_R_cirugia.Value);
                int I_ent_S_cirugia = Convert.ToInt32(numeric_I_ent_S_cirugia.Value);
                int U_ent_S_cirugia = Convert.ToInt32(numeric_U_ent_S_cirugia.Value);
                int I_ent_T_cirugia = Convert.ToInt32(numeric_I_ent_T_cirugia.Value);
                int U_ent_T_cirugia = Convert.ToInt32(numeric_U_ent_T_cirugia.Value);
                int I_gen_R_cirugia = Convert.ToInt32(numeric_I_gen_R_cirugia.Value);
                int U_gen_R_cirugia = Convert.ToInt32(numeric_U_gen_R_cirugia.Value);
                int I_gen_S_cirugia = Convert.ToInt32(numeric_I_gen_S_cirugia.Value);
                int U_gen_S_cirugia = Convert.ToInt32(numeric_U_gen_S_cirugia.Value);
                int I_gen_T_cirugia = Convert.ToInt32(numeric_I_gen_T_cirugia.Value);
                int U_gen_T_cirugia = Convert.ToInt32(numeric_U_gen_T_cirugia.Value);

                // Variables para el grupo electrógeno de UTI
                int I_ent_R_UTI = Convert.ToInt32(numeric_I_ent_R_UTI.Value);
                int U_ent_R_UTI = Convert.ToInt32(numeric_U_ent_R_UTI.Value);
                int I_ent_S_UTI = Convert.ToInt32(numeric_I_ent_S_UTI.Value);
                int U_ent_S_UTI = Convert.ToInt32(numeric_U_ent_S_UTI.Value);
                int I_ent_T_UTI = Convert.ToInt32(numeric_I_ent_T_UTI.Value);
                int U_ent_T_UTI = Convert.ToInt32(numeric_U_ent_T_UTI.Value);
                int I_gen_R_UTI = Convert.ToInt32(numeric_I_gen_R_UTI.Value);
                int U_gen_R_UTI = Convert.ToInt32(numeric_U_gen_R_UTI.Value);
                int I_gen_S_UTI = Convert.ToInt32(numeric_I_gen_S_UTI.Value);
                int U_gen_S_UTI = Convert.ToInt32(numeric_U_gen_S_UTI.Value);
                int I_gen_T_UTI = Convert.ToInt32(numeric_I_gen_T_UTI.Value);
                int U_gen_T_UTI = Convert.ToInt32(numeric_U_gen_T_UTI.Value);

                // Variables para el grupo electrógeno de bioterio
                int I_ent_R_bioterio = Convert.ToInt32(numeric_I_ent_R_bioterio.Value);
                int U_ent_R_bioterio = Convert.ToInt32(numeric_U_ent_R_bioterio.Value);
                int I_ent_S_bioterio = Convert.ToInt32(numeric_I_ent_S_bioterio.Value);
                int U_ent_S_bioterio = Convert.ToInt32(numeric_U_ent_S_bioterio.Value);
                int I_ent_T_bioterio = Convert.ToInt32(numeric_I_ent_T_bioterio.Value);
                int U_ent_T_bioterio = Convert.ToInt32(numeric_U_ent_T_bioterio.Value);
                int I_gen_R_bioterio = Convert.ToInt32(numeric_I_gen_R_bioterio.Value);
                int U_gen_R_bioterio = Convert.ToInt32(numeric_U_gen_R_bioterio.Value);
                int I_gen_S_bioterio = Convert.ToInt32(numeric_I_gen_S_bioterio.Value);
                int U_gen_S_bioterio = Convert.ToInt32(numeric_U_gen_S_bioterio.Value);
                int I_gen_T_bioterio = Convert.ToInt32(numeric_I_gen_T_bioterio.Value);
                int U_gen_T_bioterio = Convert.ToInt32(numeric_U_gen_T_bioterio.Value);

                int HorasUso_resonador = Convert.ToInt32(numeric_hora_resonador.Value);
                int HorasUso_ultrafrezeers = Convert.ToInt32(numeric_hora_ultrafrezeers.Value);
                int HorasUso_patologia = Convert.ToInt32(numeric_hora_patologia.Value);
                int HorasUso_cirugia = Convert.ToInt32(numeric_hora_cirugia.Value);
                int HorasUso_UTI = Convert.ToInt32(numeric_hora_UTI.Value);


                int Min_uso_resonador = Convert.ToInt32(numeric_min_resonador.Text);
                int Min_uso_ultrafrezeers = Convert.ToInt32(numeric_min_ultrafrezeers.Text);
                int Min_uso_patologia = Convert.ToInt32(numeric_min_patologia.Text);
                int Min_uso_cirugia = Convert.ToInt32(numeric_min_cirugia.Text);
                int Min_uso_UTI = Convert.ToInt32(numeric_min_UTI.Text);

                
                string tiempo = numeric_hora_bioterio.Text; // Tiempo en formato "hh,m"
                string[] partesTiempo = tiempo.Split('.', ',');
                int horas_bioterio = int.Parse(partesTiempo[0]);
                partesTiempo[1] = "0";
                int min_bioterio = (int)(double.Parse("0," + partesTiempo[1]) * 60);



                //if (Chequeo())
                
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



                    string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();


                            // Insertar el nuevo reporte de grupo electrógeno
                            string insertar_reporte_Query = @"INSERT INTO reporte_grupo_electrogeno 
                                        (Fecha, Observaciones_grupo, Refrigerante, Nivel_Aceite, Nivel_Agua_Bateria, 
                                        Nivel_Combustible, Voltaje_Bateria_Reposo, Voltaje_Bateria_Carga, Frecuencia, 
                                        RPM, Temperatura,HorasUso,Minutos_uso, Presion_Aceite, Numero_Arranques, 
                                        V_Generador_R, V_Generador_S, V_Generador_T, V_Linea_R, V_Linea_S, V_Linea_T, 
                                        A_Generador_R, A_Generador_S, A_Generador_T, Estado, grupo_electrogeno_Id_grupo, 
                                        A_Linea_R, A_Linea_S, A_Linea_T)
                                        VALUES 
                                        (NOW(), @Observaciones_grupo, @Refrigerante, @Nivel_Aceite, @Nivel_Agua_Bateria, 
                                        @Nivel_Combustible, @Voltaje_Bateria_Reposo, @Voltaje_Bateria_Carga, @Frecuencia, 
                                        @RPM, @Temperatura,@HorasUso,@Minutos_uso ,@Presion_Aceite, @Numero_Arranques, 
                                        @V_Generador_R, @V_Generador_S, @V_Generador_T, @V_Linea_R, @V_Linea_S, @V_Linea_T, 
                                        @A_Generador_R, @A_Generador_S, @A_Generador_T, @Estado, @grupo_electrogeno_Id_grupo, 
                                        @A_Linea_R, @A_Linea_S, @A_Linea_T)";

                            try
                            {
                                using (MySqlCommand insertar_reporte_Command_resonador = new MySqlCommand(insertar_reporte_Query, connection))
                                {
                                    // Parámetros del comando SQL

                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Observaciones_grupo", DBNull.Value); // Puedes ajustar esta observación
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Refrigerante", nivel_refri_resonador); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Nivel_Aceite", nivel_aceite_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Nivel_Agua_Bateria", DBNull.Value); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Nivel_Combustible", nivel_comb_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Voltaje_Bateria_Reposo", bat_reposo_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Voltaje_Bateria_Carga", bat_carga_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Frecuencia", frec_hz_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@RPM", rpm_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Temperatura", temperatura_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@HorasUso", HorasUso_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Minutos_uso", Min_uso_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Presion_Aceite", presion_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Numero_Arranques", nro_arranque_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@V_Generador_R", U_gen_R_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@V_Generador_S", U_gen_S_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@V_Generador_T", U_gen_T_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@V_Linea_R", U_ent_R_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@V_Linea_S", U_ent_S_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@V_Linea_T", U_ent_T_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@A_Generador_R", I_gen_R_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@A_Generador_S", I_gen_S_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@A_Generador_T", I_gen_T_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@Estado", estado_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@grupo_electrogeno_Id_grupo", 2); // ID del grupo electrógeno correspondiente, ajustar según la tabla
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@A_Linea_R", I_ent_R_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@A_Linea_S", I_ent_S_resonador);
                                    insertar_reporte_Command_resonador.Parameters.AddWithValue("@A_Linea_T", I_ent_T_resonador);

                                    // Ejecutar la inserción
                                    insertar_reporte_Command_resonador.ExecuteNonQuery();
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al guardar el reporte de grupo resonador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            try {

                                using (MySqlCommand insertar_reporte_Command_ultrafrezeers = new MySqlCommand(insertar_reporte_Query, connection))
                                {
                                    // Parámetros del comando SQL

                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Observaciones_grupo", DBNull.Value); // Puedes ajustar esta observación
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Refrigerante", nivel_refri_ultrafrezeers); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Nivel_Aceite", nivel_aceite_ultrafrezeers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Nivel_Agua_Bateria", DBNull.Value); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Nivel_Combustible", nivel_comb_ultrafrezeers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Voltaje_Bateria_Reposo", bat_reposo_ultrafrezeers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Voltaje_Bateria_Carga", bat_carga_ultrafrezeers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Frecuencia", frec_hz_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@RPM", rpm_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Temperatura", temperatura_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@HorasUso", HorasUso_ultrafrezeers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Minutos_uso", Min_uso_ultrafrezeers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Presion_Aceite", presion_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Numero_Arranques", nro_arranque_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@V_Generador_R", U_gen_R_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@V_Generador_S", U_gen_S_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@V_Generador_T", U_gen_T_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@V_Linea_R", U_ent_R_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@V_Linea_S", U_ent_S_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@V_Linea_T", U_ent_T_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@A_Generador_R", I_gen_R_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@A_Generador_S", I_gen_S_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@A_Generador_T", I_gen_T_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@Estado", estado_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@grupo_electrogeno_Id_grupo", 3); // ID del grupo electrógeno correspondiente, ajustar según la tabla
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@A_Linea_R", I_ent_R_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@A_Linea_S", I_ent_S_ultrafreezers);
                                    insertar_reporte_Command_ultrafrezeers.Parameters.AddWithValue("@A_Linea_T", I_ent_T_ultrafreezers);

                                    // Ejecutar la inserción
                                    insertar_reporte_Command_ultrafrezeers.ExecuteNonQuery();
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al guardar el reporte de grupo ultrafrezeers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            try
                            {

                                using (MySqlCommand insertar_reporte_Command_patologia = new MySqlCommand(insertar_reporte_Query, connection))
                                {
                                    // Parámetros del comando SQL

                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Observaciones_grupo", DBNull.Value); // Puedes ajustar esta observación
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Refrigerante", nivel_refri_patologia); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Nivel_Aceite", nivel_aceite_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Nivel_Agua_Bateria", DBNull.Value); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Nivel_Combustible", nivel_comb_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Voltaje_Bateria_Reposo", bat_reposo_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Voltaje_Bateria_Carga", bat_carga_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Frecuencia", frec_hz_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@RPM", rpm_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Temperatura", temperatura_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@HorasUso", HorasUso_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Minutos_uso", Min_uso_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Presion_Aceite", presion_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Numero_Arranques", nro_arranque_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@V_Generador_R", U_gen_R_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@V_Generador_S", U_gen_S_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@V_Generador_T", U_gen_T_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@V_Linea_R", U_ent_R_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@V_Linea_S", U_ent_S_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@V_Linea_T", U_ent_T_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@A_Generador_R", I_gen_R_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@A_Generador_S", I_gen_S_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@A_Generador_T", I_gen_T_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@Estado", estado_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@grupo_electrogeno_Id_grupo", 4); // ID del grupo electrógeno correspondiente, ajustar según la tabla
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@A_Linea_R", I_ent_R_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@A_Linea_S", I_ent_S_patologia);
                                    insertar_reporte_Command_patologia.Parameters.AddWithValue("@A_Linea_T", I_ent_T_patologia);

                                    // Ejecutar la inserción
                                    insertar_reporte_Command_patologia.ExecuteNonQuery();
                                }


                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al guardar el reporte de grupo patologia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            try
                            {
                                using (MySqlCommand insertar_reporte_Command_hemoterapia = new MySqlCommand(insertar_reporte_Query, connection))
                                {
                                    // Parámetros del comando SQL

                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Observaciones_grupo", DBNull.Value); // Puedes ajustar esta observación
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Refrigerante", nivel_refri_hemoterapia); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Nivel_Aceite", nivel_aceite_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Nivel_Agua_Bateria", nivel_agua_hemoterapia); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Nivel_Combustible", nivel_comb_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Voltaje_Bateria_Reposo", bat_reposo_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Voltaje_Bateria_Carga", bat_carga_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Frecuencia", frec_hz_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@RPM", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Temperatura", temperatura_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@HorasUso", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Minutos_uso", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Presion_Aceite", presion_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Numero_Arranques", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@V_Generador_R", U_gen_R_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@V_Generador_S", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@V_Generador_T", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@V_Linea_R", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@V_Linea_S", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@V_Linea_T", DBNull.Value);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@A_Generador_R", I_gen_R_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@A_Generador_S", I_gen_S_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@A_Generador_T", I_gen_T_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@Estado", estado_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@grupo_electrogeno_Id_grupo", 5); // ID del grupo electrógeno correspondiente, ajustar según la tabla
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@A_Linea_R", I_ent_R_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@A_Linea_S", I_ent_S_hemoterapia);
                                    insertar_reporte_Command_hemoterapia.Parameters.AddWithValue("@A_Linea_T", I_ent_T_hemoterapia);

                                    // Ejecutar la inserción
                                    insertar_reporte_Command_hemoterapia.ExecuteNonQuery();
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al guardar el reporte de grupo hemoterapia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }



                             try
                             {

                                 using (MySqlCommand insertar_reporte_Command_cirugia = new MySqlCommand(insertar_reporte_Query, connection))
                                 {
                                     // Parámetros del comando SQL

                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Observaciones_grupo", DBNull.Value); // Puedes ajustar esta observación
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Refrigerante", nivel_refri_cirugia); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Nivel_Aceite", nivel_aceite_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Nivel_Agua_Bateria", DBNull.Value); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Nivel_Combustible", nivel_comb_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Voltaje_Bateria_Reposo", bat_reposo_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Voltaje_Bateria_Carga", bat_carga_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Frecuencia", frec_hz_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@RPM", rpm_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Temperatura", temperatura_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@HorasUso", HorasUso_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Minutos_uso", Min_uso_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Presion_Aceite", presion_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Numero_Arranques", nro_arranque_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@V_Generador_R", U_gen_R_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@V_Generador_S", U_gen_S_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@V_Generador_T", U_gen_T_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@V_Linea_R", U_ent_R_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@V_Linea_S", U_ent_S_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@V_Linea_T", U_ent_T_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@A_Generador_R", I_gen_R_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@A_Generador_S", I_gen_S_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@A_Generador_T", I_gen_T_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@Estado", estado_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@grupo_electrogeno_Id_grupo", 7); // ID del grupo electrógeno correspondiente, ajustar según la tabla
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@A_Linea_R", I_ent_R_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@A_Linea_S", I_ent_S_cirugia);
                                    insertar_reporte_Command_cirugia.Parameters.AddWithValue("@A_Linea_T", I_ent_T_cirugia);

                                    // Ejecutar la inserción
                                    insertar_reporte_Command_cirugia.ExecuteNonQuery();
                                     }

                             }
                             catch (Exception ex)
                             {

                                MessageBox.Show("Error al guardar el reporte de grupo cirugia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                             }


                            try
                            {

                                using (MySqlCommand insertar_reporte_Command_UTI = new MySqlCommand(insertar_reporte_Query, connection))
                                {
                                    // Parámetros del comando SQL

                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Observaciones_grupo", DBNull.Value); // Puedes ajustar esta observación
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Refrigerante", nivel_refri_UTI); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Nivel_Aceite", nivel_aceite_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Nivel_Agua_Bateria", nivel_agua_UTI); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Nivel_Combustible", nivel_comb_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Voltaje_Bateria_Reposo", bat_reposo_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Voltaje_Bateria_Carga", bat_carga_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Frecuencia", frec_hz_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@RPM", DBNull.Value);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Temperatura", temperatura_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@HorasUso", HorasUso_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Minutos_uso", Min_uso_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Presion_Aceite", presion_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Numero_Arranques", nro_arranque_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@V_Generador_R", U_gen_R_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@V_Generador_S", U_gen_S_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@V_Generador_T", U_gen_T_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@V_Linea_R", U_ent_R_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@V_Linea_S", U_ent_S_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@V_Linea_T", U_ent_T_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@A_Generador_R", I_gen_R_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@A_Generador_S", I_gen_S_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@A_Generador_T", I_gen_T_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@Estado", estado_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@grupo_electrogeno_Id_grupo", 6); // ID del grupo electrógeno correspondiente, ajustar según la tabla
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@A_Linea_R", I_ent_R_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@A_Linea_S", I_ent_S_UTI);
                                    insertar_reporte_Command_UTI.Parameters.AddWithValue("@A_Linea_T", I_ent_T_UTI);

                                    // Ejecutar la inserción
                                    insertar_reporte_Command_UTI.ExecuteNonQuery();
                                }


                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al guardar el reporte de grupo UTI: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            try
                            {
                                using (MySqlCommand insertar_reporte_Command_bioterio = new MySqlCommand(insertar_reporte_Query, connection))
                                {
                                    // Parámetros del comando SQL

                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Observaciones_grupo", DBNull.Value); // Puedes ajustar esta observación
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Refrigerante", nivel_refri_bioterio); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Nivel_Aceite", nivel_aceite_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Nivel_Agua_Bateria", DBNull.Value); // Ejemplo: usar una variable específica para cada equipo
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Nivel_Combustible", nivel_comb_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Voltaje_Bateria_Reposo", bat_reposo_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Voltaje_Bateria_Carga", bat_carga_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Frecuencia", frec_hz_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@RPM", rpm_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Temperatura", temperatura_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@HorasUso", horas_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Minutos_uso", min_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Presion_Aceite", presion_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Numero_Arranques", nro_arranque_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@V_Generador_R", U_gen_R_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@V_Generador_S", U_gen_S_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@V_Generador_T", U_gen_T_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@V_Linea_R", U_ent_R_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@V_Linea_S", U_ent_S_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@V_Linea_T", U_ent_T_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@A_Generador_R", I_gen_R_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@A_Generador_S", I_gen_S_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@A_Generador_T", I_gen_T_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@Estado", estado_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@grupo_electrogeno_Id_grupo", 1); // ID del grupo electrógeno correspondiente, ajustar según la tabla
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@A_Linea_R", I_ent_R_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@A_Linea_S", I_ent_S_bioterio);
                                    insertar_reporte_Command_bioterio.Parameters.AddWithValue("@A_Linea_T", I_ent_T_bioterio);

                                    // Ejecutar la inserción
                                    insertar_reporte_Command_bioterio.ExecuteNonQuery();
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al guardar el reporte de grupo bioterio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }




                            MessageBox.Show("Reporte de grupo electrógeno guardado exitosamente.", "Mensaje", MessageBoxButtons.OK);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar el reporte de grupo electrógeno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                    }
            }
        }


    }
}
