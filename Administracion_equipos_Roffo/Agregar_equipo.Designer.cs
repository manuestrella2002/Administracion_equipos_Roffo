﻿namespace Administracion_equipos_Roffo
{
    partial class Agregar_equipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nombre_equipo = new System.Windows.Forms.Label();
            this.textBox_nombre_equipo = new System.Windows.Forms.TextBox();
            this.label_marca_equipo = new System.Windows.Forms.Label();
            this.label_modelo_equipo = new System.Windows.Forms.Label();
            this.label_nro_serie_equipo = new System.Windows.Forms.Label();
            this.label_fecha_fab = new System.Windows.Forms.Label();
            this.label_fecha_adq = new System.Windows.Forms.Label();
            this.label_ubicacion = new System.Windows.Forms.Label();
            this.label_Estado = new System.Windows.Forms.Label();
            this.textBox_modelo_equipo = new System.Windows.Forms.TextBox();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.textBox_nro_serie_equipo = new System.Windows.Forms.TextBox();
            this.comboBox_ubicacion = new System.Windows.Forms.ComboBox();
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.button_guardar_equipo = new System.Windows.Forms.Button();
            this.dateTime_fecha_fab = new System.Windows.Forms.DateTimePicker();
            this.dateTime_fecha_adq = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_nombre_equipo
            // 
            this.label_nombre_equipo.AutoSize = true;
            this.label_nombre_equipo.Location = new System.Drawing.Point(32, 24);
            this.label_nombre_equipo.Name = "label_nombre_equipo";
            this.label_nombre_equipo.Size = new System.Drawing.Size(47, 13);
            this.label_nombre_equipo.TabIndex = 0;
            this.label_nombre_equipo.Text = "Nombre:";
            // 
            // textBox_nombre_equipo
            // 
            this.textBox_nombre_equipo.Location = new System.Drawing.Point(85, 21);
            this.textBox_nombre_equipo.Name = "textBox_nombre_equipo";
            this.textBox_nombre_equipo.Size = new System.Drawing.Size(274, 20);
            this.textBox_nombre_equipo.TabIndex = 1;
            // 
            // label_marca_equipo
            // 
            this.label_marca_equipo.AutoSize = true;
            this.label_marca_equipo.Location = new System.Drawing.Point(32, 57);
            this.label_marca_equipo.Name = "label_marca_equipo";
            this.label_marca_equipo.Size = new System.Drawing.Size(40, 13);
            this.label_marca_equipo.TabIndex = 2;
            this.label_marca_equipo.Text = "Marca:";
            this.label_marca_equipo.Click += new System.EventHandler(this.label_marca_equipo_Click);
            // 
            // label_modelo_equipo
            // 
            this.label_modelo_equipo.AutoSize = true;
            this.label_modelo_equipo.Location = new System.Drawing.Point(32, 91);
            this.label_modelo_equipo.Name = "label_modelo_equipo";
            this.label_modelo_equipo.Size = new System.Drawing.Size(45, 13);
            this.label_modelo_equipo.TabIndex = 3;
            this.label_modelo_equipo.Text = "Modelo:";
            // 
            // label_nro_serie_equipo
            // 
            this.label_nro_serie_equipo.AutoSize = true;
            this.label_nro_serie_equipo.Location = new System.Drawing.Point(32, 125);
            this.label_nro_serie_equipo.Name = "label_nro_serie_equipo";
            this.label_nro_serie_equipo.Size = new System.Drawing.Size(87, 13);
            this.label_nro_serie_equipo.TabIndex = 4;
            this.label_nro_serie_equipo.Text = "Numero de serie:";
            // 
            // label_fecha_fab
            // 
            this.label_fecha_fab.AutoSize = true;
            this.label_fecha_fab.Location = new System.Drawing.Point(32, 166);
            this.label_fecha_fab.Name = "label_fecha_fab";
            this.label_fecha_fab.Size = new System.Drawing.Size(95, 13);
            this.label_fecha_fab.TabIndex = 5;
            this.label_fecha_fab.Text = "Fecha fabricación:";
            // 
            // label_fecha_adq
            // 
            this.label_fecha_adq.AutoSize = true;
            this.label_fecha_adq.Location = new System.Drawing.Point(32, 200);
            this.label_fecha_adq.Name = "label_fecha_adq";
            this.label_fecha_adq.Size = new System.Drawing.Size(96, 13);
            this.label_fecha_adq.TabIndex = 6;
            this.label_fecha_adq.Text = "Fecha adquisición:";
            // 
            // label_ubicacion
            // 
            this.label_ubicacion.AutoSize = true;
            this.label_ubicacion.Location = new System.Drawing.Point(32, 235);
            this.label_ubicacion.Name = "label_ubicacion";
            this.label_ubicacion.Size = new System.Drawing.Size(58, 13);
            this.label_ubicacion.TabIndex = 7;
            this.label_ubicacion.Text = "Ubicación:";
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Location = new System.Drawing.Point(32, 268);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(43, 13);
            this.label_Estado.TabIndex = 8;
            this.label_Estado.Text = "Estado:";
            // 
            // textBox_modelo_equipo
            // 
            this.textBox_modelo_equipo.Location = new System.Drawing.Point(83, 88);
            this.textBox_modelo_equipo.Name = "textBox_modelo_equipo";
            this.textBox_modelo_equipo.Size = new System.Drawing.Size(177, 20);
            this.textBox_modelo_equipo.TabIndex = 10;
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Location = new System.Drawing.Point(85, 54);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(175, 21);
            this.comboBox_marca.TabIndex = 12;
            // 
            // textBox_nro_serie_equipo
            // 
            this.textBox_nro_serie_equipo.Location = new System.Drawing.Point(125, 122);
            this.textBox_nro_serie_equipo.Name = "textBox_nro_serie_equipo";
            this.textBox_nro_serie_equipo.Size = new System.Drawing.Size(177, 20);
            this.textBox_nro_serie_equipo.TabIndex = 13;
            // 
            // comboBox_ubicacion
            // 
            this.comboBox_ubicacion.FormattingEnabled = true;
            this.comboBox_ubicacion.Location = new System.Drawing.Point(96, 232);
            this.comboBox_ubicacion.Name = "comboBox_ubicacion";
            this.comboBox_ubicacion.Size = new System.Drawing.Size(175, 21);
            this.comboBox_ubicacion.TabIndex = 14;
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Items.AddRange(new object[] {
            "Fuera de servicio",
            "Operativo"});
            this.comboBox_estado.Location = new System.Drawing.Point(81, 265);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(122, 21);
            this.comboBox_estado.TabIndex = 15;
            // 
            // button_guardar_equipo
            // 
            this.button_guardar_equipo.Location = new System.Drawing.Point(374, 296);
            this.button_guardar_equipo.Name = "button_guardar_equipo";
            this.button_guardar_equipo.Size = new System.Drawing.Size(100, 23);
            this.button_guardar_equipo.TabIndex = 16;
            this.button_guardar_equipo.Text = "Guardar equipo";
            this.button_guardar_equipo.UseVisualStyleBackColor = true;
            this.button_guardar_equipo.Click += new System.EventHandler(this.button_guardar_equipo_Click);
            // 
            // dateTime_fecha_fab
            // 
            this.dateTime_fecha_fab.CustomFormat = "dd-mm-yyyy";
            this.dateTime_fecha_fab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_fecha_fab.Location = new System.Drawing.Point(133, 166);
            this.dateTime_fecha_fab.Name = "dateTime_fecha_fab";
            this.dateTime_fecha_fab.ShowCheckBox = true;
            this.dateTime_fecha_fab.Size = new System.Drawing.Size(138, 20);
            this.dateTime_fecha_fab.TabIndex = 17;
            // 
            // dateTime_fecha_adq
            // 
            this.dateTime_fecha_adq.CustomFormat = "dd-mm-yyyy";
            this.dateTime_fecha_adq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_fecha_adq.Location = new System.Drawing.Point(133, 200);
            this.dateTime_fecha_adq.Name = "dateTime_fecha_adq";
            this.dateTime_fecha_adq.ShowCheckBox = true;
            this.dateTime_fecha_adq.Size = new System.Drawing.Size(138, 20);
            this.dateTime_fecha_adq.TabIndex = 18;
            // 
            // Agregar_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 331);
            this.Controls.Add(this.dateTime_fecha_adq);
            this.Controls.Add(this.dateTime_fecha_fab);
            this.Controls.Add(this.button_guardar_equipo);
            this.Controls.Add(this.comboBox_estado);
            this.Controls.Add(this.comboBox_ubicacion);
            this.Controls.Add(this.textBox_nro_serie_equipo);
            this.Controls.Add(this.comboBox_marca);
            this.Controls.Add(this.textBox_modelo_equipo);
            this.Controls.Add(this.label_Estado);
            this.Controls.Add(this.label_ubicacion);
            this.Controls.Add(this.label_fecha_adq);
            this.Controls.Add(this.label_fecha_fab);
            this.Controls.Add(this.label_nro_serie_equipo);
            this.Controls.Add(this.label_modelo_equipo);
            this.Controls.Add(this.label_marca_equipo);
            this.Controls.Add(this.textBox_nombre_equipo);
            this.Controls.Add(this.label_nombre_equipo);
            this.Name = "Agregar_equipo";
            this.Text = "Agregar Equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre_equipo;
        private System.Windows.Forms.TextBox textBox_nombre_equipo;
        private System.Windows.Forms.Label label_marca_equipo;
        private System.Windows.Forms.Label label_modelo_equipo;
        private System.Windows.Forms.Label label_nro_serie_equipo;
        private System.Windows.Forms.Label label_fecha_fab;
        private System.Windows.Forms.Label label_fecha_adq;
        private System.Windows.Forms.Label label_ubicacion;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.TextBox textBox_modelo_equipo;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.TextBox textBox_nro_serie_equipo;
        private System.Windows.Forms.ComboBox comboBox_ubicacion;
        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.Button button_guardar_equipo;
        private System.Windows.Forms.DateTimePicker dateTime_fecha_fab;
        private System.Windows.Forms.DateTimePicker dateTime_fecha_adq;
    }
}