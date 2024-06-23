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
            this.label_proveedor = new System.Windows.Forms.Label();
            this.textBox_nombre_parte = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // label_proveedor
            // 
            this.label_proveedor.AutoSize = true;
            this.label_proveedor.Location = new System.Drawing.Point(28, 194);
            this.label_proveedor.Name = "label_proveedor";
            this.label_proveedor.Size = new System.Drawing.Size(59, 13);
            this.label_proveedor.TabIndex = 4;
            this.label_proveedor.Text = "Proveedor:";
            // 
            // textBox_nombre_parte
            // 
            this.textBox_nombre_parte.Location = new System.Drawing.Point(81, 27);
            this.textBox_nombre_parte.Name = "textBox_nombre_parte";
            this.textBox_nombre_parte.Size = new System.Drawing.Size(207, 20);
            this.textBox_nombre_parte.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(136, 92);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(100, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 36);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // Agregar_parte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 247);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_nombre_parte);
            this.Controls.Add(this.label_proveedor);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.label_cantidad);
            this.Controls.Add(this.label_marca_parte);
            this.Controls.Add(this.label_nombre_parte);
            this.Name = "Agregar_parte";
            this.Text = "Agregar_parte";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre_parte;
        private System.Windows.Forms.Label label_marca_parte;
        private System.Windows.Forms.Label label_cantidad;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_proveedor;
        private System.Windows.Forms.TextBox textBox_nombre_parte;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}