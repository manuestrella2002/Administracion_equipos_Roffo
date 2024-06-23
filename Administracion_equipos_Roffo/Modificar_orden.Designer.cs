namespace Administracion_equipos_Roffo
{
    partial class Modificar_orden
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
            this.label_descripcion = new System.Windows.Forms.Label();
            this.textBox_descripcion_orden = new System.Windows.Forms.TextBox();
            this.comboBox_lugar_orden = new System.Windows.Forms.ComboBox();
            this.label_lugar = new System.Windows.Forms.Label();
            this.button_guardar_cambios = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(30, 58);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_descripcion.TabIndex = 0;
            this.label_descripcion.Text = "Descripción:";
            // 
            // textBox_descripcion_orden
            // 
            this.textBox_descripcion_orden.AcceptsReturn = true;
            this.textBox_descripcion_orden.AcceptsTab = true;
            this.textBox_descripcion_orden.AllowDrop = true;
            this.textBox_descripcion_orden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_descripcion_orden.Location = new System.Drawing.Point(111, 55);
            this.textBox_descripcion_orden.Multiline = true;
            this.textBox_descripcion_orden.Name = "textBox_descripcion_orden";
            this.textBox_descripcion_orden.Size = new System.Drawing.Size(372, 108);
            this.textBox_descripcion_orden.TabIndex = 3;
            // 
            // comboBox_lugar_orden
            // 
            this.comboBox_lugar_orden.FormattingEnabled = true;
            this.comboBox_lugar_orden.Location = new System.Drawing.Point(117, 204);
            this.comboBox_lugar_orden.Name = "comboBox_lugar_orden";
            this.comboBox_lugar_orden.Size = new System.Drawing.Size(165, 21);
            this.comboBox_lugar_orden.TabIndex = 6;
            // 
            // label_lugar
            // 
            this.label_lugar.AutoSize = true;
            this.label_lugar.Location = new System.Drawing.Point(59, 207);
            this.label_lugar.Name = "label_lugar";
            this.label_lugar.Size = new System.Drawing.Size(37, 13);
            this.label_lugar.TabIndex = 5;
            this.label_lugar.Text = "Lugar:";
            // 
            // button_guardar_cambios
            // 
            this.button_guardar_cambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_guardar_cambios.Location = new System.Drawing.Point(435, 281);
            this.button_guardar_cambios.Name = "button_guardar_cambios";
            this.button_guardar_cambios.Size = new System.Drawing.Size(95, 42);
            this.button_guardar_cambios.TabIndex = 7;
            this.button_guardar_cambios.Text = "Guardar cambios";
            this.button_guardar_cambios.UseVisualStyleBackColor = true;
            this.button_guardar_cambios.Click += new System.EventHandler(this.button_guardar_cambios_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancelar.Location = new System.Drawing.Point(317, 281);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(95, 42);
            this.button_cancelar.TabIndex = 8;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // Modificar_orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 335);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_guardar_cambios);
            this.Controls.Add(this.comboBox_lugar_orden);
            this.Controls.Add(this.label_lugar);
            this.Controls.Add(this.textBox_descripcion_orden);
            this.Controls.Add(this.label_descripcion);
            this.Name = "Modificar_orden";
            this.Text = "Modificar_orden";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.TextBox textBox_descripcion_orden;
        private System.Windows.Forms.ComboBox comboBox_lugar_orden;
        private System.Windows.Forms.Label label_lugar;
        private System.Windows.Forms.Button button_guardar_cambios;
        private System.Windows.Forms.Button button_cancelar;
    }
}