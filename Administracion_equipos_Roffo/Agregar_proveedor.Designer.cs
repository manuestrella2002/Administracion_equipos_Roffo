namespace Administracion_equipos_Roffo
{
    partial class Agregar_proveedor
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
            this.label_nombre_prov = new System.Windows.Forms.Label();
            this.textBox_nombre_prov = new System.Windows.Forms.TextBox();
            this.label_calle = new System.Windows.Forms.Label();
            this.textBox_calle = new System.Windows.Forms.TextBox();
            this.label_nro = new System.Windows.Forms.Label();
            this.maskedTextBox_nro = new System.Windows.Forms.MaskedTextBox();
            this.label_Localidad = new System.Windows.Forms.Label();
            this.comboBox_localidad = new System.Windows.Forms.ComboBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label_telefono = new System.Windows.Forms.Label();
            this.maskedTextBox_telefono = new System.Windows.Forms.MaskedTextBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nombre_prov
            // 
            this.label_nombre_prov.AutoSize = true;
            this.label_nombre_prov.Location = new System.Drawing.Point(23, 33);
            this.label_nombre_prov.Name = "label_nombre_prov";
            this.label_nombre_prov.Size = new System.Drawing.Size(47, 13);
            this.label_nombre_prov.TabIndex = 0;
            this.label_nombre_prov.Text = "Nombre:";
            // 
            // textBox_nombre_prov
            // 
            this.textBox_nombre_prov.Location = new System.Drawing.Point(76, 30);
            this.textBox_nombre_prov.Name = "textBox_nombre_prov";
            this.textBox_nombre_prov.Size = new System.Drawing.Size(194, 20);
            this.textBox_nombre_prov.TabIndex = 1;
            // 
            // label_calle
            // 
            this.label_calle.AutoSize = true;
            this.label_calle.Location = new System.Drawing.Point(23, 81);
            this.label_calle.Name = "label_calle";
            this.label_calle.Size = new System.Drawing.Size(33, 13);
            this.label_calle.TabIndex = 2;
            this.label_calle.Text = "Calle:";
            // 
            // textBox_calle
            // 
            this.textBox_calle.Location = new System.Drawing.Point(76, 78);
            this.textBox_calle.Name = "textBox_calle";
            this.textBox_calle.Size = new System.Drawing.Size(194, 20);
            this.textBox_calle.TabIndex = 3;
            // 
            // label_nro
            // 
            this.label_nro.AutoSize = true;
            this.label_nro.Location = new System.Drawing.Point(23, 121);
            this.label_nro.Name = "label_nro";
            this.label_nro.Size = new System.Drawing.Size(47, 13);
            this.label_nro.TabIndex = 4;
            this.label_nro.Text = "Número:";
            // 
            // maskedTextBox_nro
            // 
            this.maskedTextBox_nro.Location = new System.Drawing.Point(76, 118);
            this.maskedTextBox_nro.Mask = "99999";
            this.maskedTextBox_nro.Name = "maskedTextBox_nro";
            this.maskedTextBox_nro.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBox_nro.TabIndex = 5;
            this.maskedTextBox_nro.ValidatingType = typeof(int);
            // 
            // label_Localidad
            // 
            this.label_Localidad.AutoSize = true;
            this.label_Localidad.Location = new System.Drawing.Point(23, 158);
            this.label_Localidad.Name = "label_Localidad";
            this.label_Localidad.Size = new System.Drawing.Size(56, 13);
            this.label_Localidad.TabIndex = 6;
            this.label_Localidad.Text = "Localidad:";
            // 
            // comboBox_localidad
            // 
            this.comboBox_localidad.FormattingEnabled = true;
            this.comboBox_localidad.Location = new System.Drawing.Point(85, 155);
            this.comboBox_localidad.Name = "comboBox_localidad";
            this.comboBox_localidad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_localidad.TabIndex = 7;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(23, 203);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(29, 13);
            this.label_mail.TabIndex = 8;
            this.label_mail.Text = "Mail:";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(76, 200);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(194, 20);
            this.textBox_mail.TabIndex = 9;
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(23, 246);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(52, 13);
            this.label_telefono.TabIndex = 10;
            this.label_telefono.Text = "Teléfono:";
            // 
            // maskedTextBox_telefono
            // 
            this.maskedTextBox_telefono.Location = new System.Drawing.Point(76, 243);
            this.maskedTextBox_telefono.Mask = "0000000000";
            this.maskedTextBox_telefono.Name = "maskedTextBox_telefono";
            this.maskedTextBox_telefono.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBox_telefono.TabIndex = 11;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(354, 246);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(89, 43);
            this.button_guardar.TabIndex = 12;
            this.button_guardar.Text = "Guardar proveedor";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // Agregar_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 301);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.maskedTextBox_telefono);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.comboBox_localidad);
            this.Controls.Add(this.label_Localidad);
            this.Controls.Add(this.maskedTextBox_nro);
            this.Controls.Add(this.label_nro);
            this.Controls.Add(this.textBox_calle);
            this.Controls.Add(this.label_calle);
            this.Controls.Add(this.textBox_nombre_prov);
            this.Controls.Add(this.label_nombre_prov);
            this.Name = "Agregar_proveedor";
            this.Text = "Agregar nuevo proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre_prov;
        private System.Windows.Forms.TextBox textBox_nombre_prov;
        private System.Windows.Forms.Label label_calle;
        private System.Windows.Forms.TextBox textBox_calle;
        private System.Windows.Forms.Label label_nro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_nro;
        private System.Windows.Forms.Label label_Localidad;
        private System.Windows.Forms.ComboBox comboBox_localidad;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefono;
        private System.Windows.Forms.Button button_guardar;
    }
}