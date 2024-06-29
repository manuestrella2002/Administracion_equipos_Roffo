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

namespace Administracion_equipos_Roffo
{
    public partial class Agregar_reporte_grupo : Form
    {
        public Agregar_reporte_grupo()
        {
            InitializeComponent();
        }

        private void Chequeo()
        {
            // NIVEL ACEITE
            if (radioButton_aceite_mal_reso.Checked == false && radioButton_aceite_ok_reso.Checked == false && radioButton_aceite_ok_osc_reso.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite resonador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radioButton_aceite_mal_ultrafrezeers.Checked == false && radioButton_aceite_ok_ultrafreezers.Checked == false && radioButton_aceite_ok_osc_ultrafreezers.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite ultrafrezeers", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radioButton_aceite_mal_patologia.Checked == false && radioButton_aceite_ok_patologia.Checked == false && radioButton_aceite_ok_osc_patologia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite patologia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radioButton_aceite_mal_cirugia.Checked == false && radioButton_aceite_ok_cirugia.Checked == false && radioButton_aceite_ok_osc_cirugia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite cirugia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radioButton_aceite_mal_hemoterapia.Checked == false && radioButton_aceite_ok_hemoterapia.Checked == false && radioButton_aceite_ok_osc_hemoterapia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite hemoterapia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radioButton_aceite_mal_UTI.Checked == false && radioButton_aceite_ok_uti.Checked == false && radioButton_aceite_ok_osc_UTI.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite UTI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radioButton_aceite_mal_bioterio.Checked == false && radioButton_aceite_ok_bioterio.Checked == false && radioButton_aceite_ok_osc_bioterio.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel aceite bioterio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // NIVEL REFRIGERANTE
            if (radiobutton_Refri_ok_resonador.Checked == false && radioButton_refri_mal_resonador.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante resonador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radiobutton_Refri_ok_ultrafrezeers.Checked == false && radioButton_refri_mal_ultrafrezeers.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante ultrafrezeers", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radiobutton_Refri_ok_patologia.Checked == false && radioButton_refri_mal_patologia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante patologia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radiobutton_Refri_ok_cirugia.Checked == false && radioButton_refri_mal_cirugia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante cirugia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radiobutton_Refri_ok_hemoterapia.Checked == false && radioButton_refri_mal_hemoterapia.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante hemoterapia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radiobutton_Refri_ok_UTI.Checked == false && radioButton_refri_mal_UTI.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante UTI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radiobutton_Refri_ok_bioterio.Checked == false && radioButton_refri_mal_bioterio.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel refrigerante bioterio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // NIVEL AGUA BATERIA
            if (radioButton_agua_bat_ok_hemoterapia.Checked == false && radioButton_agua_bat_bajo_hemoterapia.Checked == false)
            {
                  DialogResult Resultado;
                  Resultado = MessageBox.Show("Falta seleccionar nivel agua bateria hemoterapia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radioButton_agua_bat_ok_UTI.Checked == false && radioButton_agua_bat_bajo_UTI.Checked == false)
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Falta seleccionar nivel agua bateria UTI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





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

        }
    }
}
