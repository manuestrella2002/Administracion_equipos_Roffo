namespace Administracion_equipos_Roffo
{
    partial class Agregar_orden
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
            this.label_nueva_orden = new System.Windows.Forms.Label();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.textBox_descripcion_orden = new System.Windows.Forms.TextBox();
            this.label_lugar = new System.Windows.Forms.Label();
            this.comboBox_lugar_orden = new System.Windows.Forms.ComboBox();
            this.button_crear_orden = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nueva_orden
            // 
            this.label_nueva_orden.AutoSize = true;
            this.label_nueva_orden.Location = new System.Drawing.Point(229, 9);
            this.label_nueva_orden.Name = "label_nueva_orden";
            this.label_nueva_orden.Size = new System.Drawing.Size(86, 13);
            this.label_nueva_orden.TabIndex = 0;
            this.label_nueva_orden.Text = "NUEVA ORDEN";
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(25, 76);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_descripcion.TabIndex = 1;
            this.label_descripcion.Text = "Descripción:";
            // 
            // textBox_descripcion_orden
            // 
            this.textBox_descripcion_orden.AcceptsReturn = true;
            this.textBox_descripcion_orden.AcceptsTab = true;
            this.textBox_descripcion_orden.AllowDrop = true;
            this.textBox_descripcion_orden.Location = new System.Drawing.Point(97, 73);
            this.textBox_descripcion_orden.Multiline = true;
            this.textBox_descripcion_orden.Name = "textBox_descripcion_orden";
            this.textBox_descripcion_orden.Size = new System.Drawing.Size(372, 108);
            this.textBox_descripcion_orden.TabIndex = 2;
            // 
            // label_lugar
            // 
            this.label_lugar.AutoSize = true;
            this.label_lugar.Location = new System.Drawing.Point(38, 206);
            this.label_lugar.Name = "label_lugar";
            this.label_lugar.Size = new System.Drawing.Size(37, 13);
            this.label_lugar.TabIndex = 3;
            this.label_lugar.Text = "Lugar:";
            // 
            // comboBox_lugar_orden
            // 
            this.comboBox_lugar_orden.FormattingEnabled = true;
            this.comboBox_lugar_orden.Location = new System.Drawing.Point(96, 203);
            this.comboBox_lugar_orden.Name = "comboBox_lugar_orden";
            this.comboBox_lugar_orden.Size = new System.Drawing.Size(165, 21);
            this.comboBox_lugar_orden.TabIndex = 4;
            // 
            // button_crear_orden
            // 
            this.button_crear_orden.Location = new System.Drawing.Point(380, 242);
            this.button_crear_orden.Name = "button_crear_orden";
            this.button_crear_orden.Size = new System.Drawing.Size(89, 40);
            this.button_crear_orden.TabIndex = 5;
            this.button_crear_orden.Text = "Crear orden";
            this.button_crear_orden.UseVisualStyleBackColor = true;
            this.button_crear_orden.Click += new System.EventHandler(this.button_crear_orden_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agregar_orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_crear_orden);
            this.Controls.Add(this.comboBox_lugar_orden);
            this.Controls.Add(this.label_lugar);
            this.Controls.Add(this.textBox_descripcion_orden);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.label_nueva_orden);
            this.Name = "Agregar_orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_orden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nueva_orden;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.TextBox textBox_descripcion_orden;
        private System.Windows.Forms.Label label_lugar;
        private System.Windows.Forms.ComboBox comboBox_lugar_orden;
        private System.Windows.Forms.Button button_crear_orden;
        private System.Windows.Forms.Button button1;
    }
}