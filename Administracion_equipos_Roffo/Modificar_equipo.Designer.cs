namespace Administracion_equipos_Roffo
{
    partial class Modificar_equipo
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
            this.dateTime_fecha_adq = new System.Windows.Forms.DateTimePicker();
            this.dateTime_fecha_fab = new System.Windows.Forms.DateTimePicker();
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.comboBox_ubicacion = new System.Windows.Forms.ComboBox();
            this.textBox_nro_serie_equipo = new System.Windows.Forms.TextBox();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.textBox_modelo_equipo = new System.Windows.Forms.TextBox();
            this.label_Estado = new System.Windows.Forms.Label();
            this.label_ubicacion = new System.Windows.Forms.Label();
            this.label_fecha_adq = new System.Windows.Forms.Label();
            this.label_fecha_fab = new System.Windows.Forms.Label();
            this.label_nro_serie_equipo = new System.Windows.Forms.Label();
            this.label_modelo_equipo = new System.Windows.Forms.Label();
            this.label_marca_equipo = new System.Windows.Forms.Label();
            this.textBox_nombre_equipo = new System.Windows.Forms.TextBox();
            this.label_nombre_equipo = new System.Windows.Forms.Label();
            this.button_Guardar_cambios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTime_fecha_adq
            // 
            this.dateTime_fecha_adq.CustomFormat = "dd-mm-yyyy";
            this.dateTime_fecha_adq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_fecha_adq.Location = new System.Drawing.Point(126, 207);
            this.dateTime_fecha_adq.Name = "dateTime_fecha_adq";
            this.dateTime_fecha_adq.ShowCheckBox = true;
            this.dateTime_fecha_adq.Size = new System.Drawing.Size(138, 20);
            this.dateTime_fecha_adq.TabIndex = 34;
            // 
            // dateTime_fecha_fab
            // 
            this.dateTime_fecha_fab.CustomFormat = "dd-mm-yyyy";
            this.dateTime_fecha_fab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_fecha_fab.Location = new System.Drawing.Point(126, 173);
            this.dateTime_fecha_fab.Name = "dateTime_fecha_fab";
            this.dateTime_fecha_fab.ShowCheckBox = true;
            this.dateTime_fecha_fab.Size = new System.Drawing.Size(138, 20);
            this.dateTime_fecha_fab.TabIndex = 33;
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Items.AddRange(new object[] {
            "Fuera de servicio",
            "Operativo"});
            this.comboBox_estado.Location = new System.Drawing.Point(74, 272);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(122, 21);
            this.comboBox_estado.TabIndex = 32;
            // 
            // comboBox_ubicacion
            // 
            this.comboBox_ubicacion.FormattingEnabled = true;
            this.comboBox_ubicacion.Location = new System.Drawing.Point(89, 239);
            this.comboBox_ubicacion.Name = "comboBox_ubicacion";
            this.comboBox_ubicacion.Size = new System.Drawing.Size(175, 21);
            this.comboBox_ubicacion.TabIndex = 31;
            // 
            // textBox_nro_serie_equipo
            // 
            this.textBox_nro_serie_equipo.Location = new System.Drawing.Point(118, 129);
            this.textBox_nro_serie_equipo.Name = "textBox_nro_serie_equipo";
            this.textBox_nro_serie_equipo.Size = new System.Drawing.Size(177, 20);
            this.textBox_nro_serie_equipo.TabIndex = 30;
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Location = new System.Drawing.Point(78, 61);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(175, 21);
            this.comboBox_marca.TabIndex = 29;
            // 
            // textBox_modelo_equipo
            // 
            this.textBox_modelo_equipo.Location = new System.Drawing.Point(76, 95);
            this.textBox_modelo_equipo.Name = "textBox_modelo_equipo";
            this.textBox_modelo_equipo.Size = new System.Drawing.Size(177, 20);
            this.textBox_modelo_equipo.TabIndex = 28;
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Location = new System.Drawing.Point(25, 275);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(43, 13);
            this.label_Estado.TabIndex = 27;
            this.label_Estado.Text = "Estado:";
            // 
            // label_ubicacion
            // 
            this.label_ubicacion.AutoSize = true;
            this.label_ubicacion.Location = new System.Drawing.Point(25, 242);
            this.label_ubicacion.Name = "label_ubicacion";
            this.label_ubicacion.Size = new System.Drawing.Size(58, 13);
            this.label_ubicacion.TabIndex = 26;
            this.label_ubicacion.Text = "Ubicación:";
            // 
            // label_fecha_adq
            // 
            this.label_fecha_adq.AutoSize = true;
            this.label_fecha_adq.Location = new System.Drawing.Point(25, 207);
            this.label_fecha_adq.Name = "label_fecha_adq";
            this.label_fecha_adq.Size = new System.Drawing.Size(96, 13);
            this.label_fecha_adq.TabIndex = 25;
            this.label_fecha_adq.Text = "Fecha adquisición:";
            // 
            // label_fecha_fab
            // 
            this.label_fecha_fab.AutoSize = true;
            this.label_fecha_fab.Location = new System.Drawing.Point(25, 173);
            this.label_fecha_fab.Name = "label_fecha_fab";
            this.label_fecha_fab.Size = new System.Drawing.Size(95, 13);
            this.label_fecha_fab.TabIndex = 24;
            this.label_fecha_fab.Text = "Fecha fabricación:";
            // 
            // label_nro_serie_equipo
            // 
            this.label_nro_serie_equipo.AutoSize = true;
            this.label_nro_serie_equipo.Location = new System.Drawing.Point(25, 132);
            this.label_nro_serie_equipo.Name = "label_nro_serie_equipo";
            this.label_nro_serie_equipo.Size = new System.Drawing.Size(87, 13);
            this.label_nro_serie_equipo.TabIndex = 23;
            this.label_nro_serie_equipo.Text = "Numero de serie:";
            // 
            // label_modelo_equipo
            // 
            this.label_modelo_equipo.AutoSize = true;
            this.label_modelo_equipo.Location = new System.Drawing.Point(25, 98);
            this.label_modelo_equipo.Name = "label_modelo_equipo";
            this.label_modelo_equipo.Size = new System.Drawing.Size(45, 13);
            this.label_modelo_equipo.TabIndex = 22;
            this.label_modelo_equipo.Text = "Modelo:";
            // 
            // label_marca_equipo
            // 
            this.label_marca_equipo.AutoSize = true;
            this.label_marca_equipo.Location = new System.Drawing.Point(25, 64);
            this.label_marca_equipo.Name = "label_marca_equipo";
            this.label_marca_equipo.Size = new System.Drawing.Size(40, 13);
            this.label_marca_equipo.TabIndex = 21;
            this.label_marca_equipo.Text = "Marca:";
            // 
            // textBox_nombre_equipo
            // 
            this.textBox_nombre_equipo.Location = new System.Drawing.Point(78, 28);
            this.textBox_nombre_equipo.Name = "textBox_nombre_equipo";
            this.textBox_nombre_equipo.Size = new System.Drawing.Size(274, 20);
            this.textBox_nombre_equipo.TabIndex = 20;
            // 
            // label_nombre_equipo
            // 
            this.label_nombre_equipo.AutoSize = true;
            this.label_nombre_equipo.Location = new System.Drawing.Point(25, 31);
            this.label_nombre_equipo.Name = "label_nombre_equipo";
            this.label_nombre_equipo.Size = new System.Drawing.Size(47, 13);
            this.label_nombre_equipo.TabIndex = 19;
            this.label_nombre_equipo.Text = "Nombre:";
            // 
            // button_Guardar_cambios
            // 
            this.button_Guardar_cambios.Location = new System.Drawing.Point(336, 277);
            this.button_Guardar_cambios.Name = "button_Guardar_cambios";
            this.button_Guardar_cambios.Size = new System.Drawing.Size(104, 23);
            this.button_Guardar_cambios.TabIndex = 35;
            this.button_Guardar_cambios.Text = "Guardar cambios";
            this.button_Guardar_cambios.UseVisualStyleBackColor = true;
            this.button_Guardar_cambios.Click += new System.EventHandler(this.button_Guardar_cambios_Click);
            // 
            // Modificar_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 312);
            this.Controls.Add(this.button_Guardar_cambios);
            this.Controls.Add(this.dateTime_fecha_adq);
            this.Controls.Add(this.dateTime_fecha_fab);
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
            this.Name = "Modificar_equipo";
            this.Text = "Modificar_equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime_fecha_adq;
        private System.Windows.Forms.DateTimePicker dateTime_fecha_fab;
        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.ComboBox comboBox_ubicacion;
        private System.Windows.Forms.TextBox textBox_nro_serie_equipo;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.TextBox textBox_modelo_equipo;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.Label label_ubicacion;
        private System.Windows.Forms.Label label_fecha_adq;
        private System.Windows.Forms.Label label_fecha_fab;
        private System.Windows.Forms.Label label_nro_serie_equipo;
        private System.Windows.Forms.Label label_modelo_equipo;
        private System.Windows.Forms.Label label_marca_equipo;
        private System.Windows.Forms.TextBox textBox_nombre_equipo;
        private System.Windows.Forms.Label label_nombre_equipo;
        private System.Windows.Forms.Button button_Guardar_cambios;
    }
}