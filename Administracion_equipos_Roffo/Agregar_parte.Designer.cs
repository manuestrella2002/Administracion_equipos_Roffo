namespace Administracion_equipos_Roffo
{
    partial class Agregar_parte
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
            this.label_nombre_parte = new System.Windows.Forms.Label();
            this.label_marca_parte = new System.Windows.Forms.Label();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.textBox_nombre_parte = new System.Windows.Forms.TextBox();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.contador_cantidad = new System.Windows.Forms.NumericUpDown();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.button_guardar_parte = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contador_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nombre_parte
            // 
            this.label_nombre_parte.AutoSize = true;
            this.label_nombre_parte.Location = new System.Drawing.Point(28, 30);
            this.label_nombre_parte.Name = "label_nombre_parte";
            this.label_nombre_parte.Size = new System.Drawing.Size(47, 13);
            this.label_nombre_parte.TabIndex = 0;
            this.label_nombre_parte.Text = "Nombre:";
            this.label_nombre_parte.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_marca_parte
            // 
            this.label_marca_parte.AutoSize = true;
            this.label_marca_parte.Location = new System.Drawing.Point(28, 59);
            this.label_marca_parte.Name = "label_marca_parte";
            this.label_marca_parte.Size = new System.Drawing.Size(40, 13);
            this.label_marca_parte.TabIndex = 1;
            this.label_marca_parte.Text = "Marca:";
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(28, 94);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(102, 13);
            this.label_cantidad.TabIndex = 2;
            this.label_cantidad.Text = "Cantidad disponible:";
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(28, 137);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_Descripcion.TabIndex = 3;
            this.label_Descripcion.Text = "Descripción:";
            // 
            // textBox_nombre_parte
            // 
            this.textBox_nombre_parte.Location = new System.Drawing.Point(81, 27);
            this.textBox_nombre_parte.Name = "textBox_nombre_parte";
            this.textBox_nombre_parte.Size = new System.Drawing.Size(207, 20);
            this.textBox_nombre_parte.TabIndex = 5;
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Location = new System.Drawing.Point(81, 56);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(160, 21);
            this.comboBox_marca.TabIndex = 6;
            // 
            // contador_cantidad
            // 
            this.contador_cantidad.Location = new System.Drawing.Point(136, 92);
            this.contador_cantidad.Name = "contador_cantidad";
            this.contador_cantidad.Size = new System.Drawing.Size(62, 20);
            this.contador_cantidad.TabIndex = 7;
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.AcceptsReturn = true;
            this.textBox_descripcion.AcceptsTab = true;
            this.textBox_descripcion.AllowDrop = true;
            this.textBox_descripcion.Location = new System.Drawing.Point(100, 137);
            this.textBox_descripcion.Multiline = true;
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(205, 36);
            this.textBox_descripcion.TabIndex = 8;
            // 
            // button_guardar_parte
            // 
            this.button_guardar_parte.Location = new System.Drawing.Point(372, 196);
            this.button_guardar_parte.Name = "button_guardar_parte";
            this.button_guardar_parte.Size = new System.Drawing.Size(84, 38);
            this.button_guardar_parte.TabIndex = 10;
            this.button_guardar_parte.Text = "Guardar parte";
            this.button_guardar_parte.UseVisualStyleBackColor = true;
            this.button_guardar_parte.Click += new System.EventHandler(this.button_guardar_parte_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(271, 196);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(84, 38);
            this.button_cancelar.TabIndex = 11;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // Agregar_parte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 251);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_guardar_parte);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.contador_cantidad);
            this.Controls.Add(this.comboBox_marca);
            this.Controls.Add(this.textBox_nombre_parte);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.label_cantidad);
            this.Controls.Add(this.label_marca_parte);
            this.Controls.Add(this.label_nombre_parte);
            this.Name = "Agregar_parte";
            this.Text = "Agregar parte";
            ((System.ComponentModel.ISupportInitialize)(this.contador_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre_parte;
        private System.Windows.Forms.Label label_marca_parte;
        private System.Windows.Forms.Label label_cantidad;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.TextBox textBox_nombre_parte;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.NumericUpDown contador_cantidad;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Button button_guardar_parte;
        private System.Windows.Forms.Button button_cancelar;
    }
}