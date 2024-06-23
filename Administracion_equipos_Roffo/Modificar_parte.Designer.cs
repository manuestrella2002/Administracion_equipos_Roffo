namespace Administracion_equipos_Roffo
{
    partial class Modificar_parte
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
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_modificar_parte = new System.Windows.Forms.Button();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.contador_cantidad = new System.Windows.Forms.NumericUpDown();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.textBox_nombre_parte = new System.Windows.Forms.TextBox();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.label_marca_parte = new System.Windows.Forms.Label();
            this.label_nombre_parte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contador_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancelar.Location = new System.Drawing.Point(205, 194);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(84, 38);
            this.button_cancelar.TabIndex = 21;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_modificar_parte
            // 
            this.button_modificar_parte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_modificar_parte.Location = new System.Drawing.Point(306, 194);
            this.button_modificar_parte.Name = "button_modificar_parte";
            this.button_modificar_parte.Size = new System.Drawing.Size(84, 38);
            this.button_modificar_parte.TabIndex = 20;
            this.button_modificar_parte.Text = "Modificar parte";
            this.button_modificar_parte.UseVisualStyleBackColor = true;
            this.button_modificar_parte.Click += new System.EventHandler(this.button_modificar_parte_Click);
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.AcceptsReturn = true;
            this.textBox_descripcion.AcceptsTab = true;
            this.textBox_descripcion.AllowDrop = true;
            this.textBox_descripcion.Location = new System.Drawing.Point(107, 138);
            this.textBox_descripcion.Multiline = true;
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(205, 36);
            this.textBox_descripcion.TabIndex = 19;
            // 
            // contador_cantidad
            // 
            this.contador_cantidad.Location = new System.Drawing.Point(143, 93);
            this.contador_cantidad.Name = "contador_cantidad";
            this.contador_cantidad.Size = new System.Drawing.Size(62, 20);
            this.contador_cantidad.TabIndex = 18;
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Location = new System.Drawing.Point(88, 57);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(160, 21);
            this.comboBox_marca.TabIndex = 17;
            // 
            // textBox_nombre_parte
            // 
            this.textBox_nombre_parte.Location = new System.Drawing.Point(88, 28);
            this.textBox_nombre_parte.Name = "textBox_nombre_parte";
            this.textBox_nombre_parte.Size = new System.Drawing.Size(207, 20);
            this.textBox_nombre_parte.TabIndex = 16;
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(35, 138);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_Descripcion.TabIndex = 15;
            this.label_Descripcion.Text = "Descripción:";
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(35, 95);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(102, 13);
            this.label_cantidad.TabIndex = 14;
            this.label_cantidad.Text = "Cantidad disponible:";
            // 
            // label_marca_parte
            // 
            this.label_marca_parte.AutoSize = true;
            this.label_marca_parte.Location = new System.Drawing.Point(35, 60);
            this.label_marca_parte.Name = "label_marca_parte";
            this.label_marca_parte.Size = new System.Drawing.Size(40, 13);
            this.label_marca_parte.TabIndex = 13;
            this.label_marca_parte.Text = "Marca:";
            // 
            // label_nombre_parte
            // 
            this.label_nombre_parte.AutoSize = true;
            this.label_nombre_parte.Location = new System.Drawing.Point(35, 31);
            this.label_nombre_parte.Name = "label_nombre_parte";
            this.label_nombre_parte.Size = new System.Drawing.Size(47, 13);
            this.label_nombre_parte.TabIndex = 12;
            this.label_nombre_parte.Text = "Nombre:";
            // 
            // Modificar_parte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 244);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_modificar_parte);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.contador_cantidad);
            this.Controls.Add(this.comboBox_marca);
            this.Controls.Add(this.textBox_nombre_parte);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.label_cantidad);
            this.Controls.Add(this.label_marca_parte);
            this.Controls.Add(this.label_nombre_parte);
            this.Name = "Modificar_parte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar parte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.contador_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_modificar_parte;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.NumericUpDown contador_cantidad;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.TextBox textBox_nombre_parte;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_cantidad;
        private System.Windows.Forms.Label label_marca_parte;
        private System.Windows.Forms.Label label_nombre_parte;
    }
}