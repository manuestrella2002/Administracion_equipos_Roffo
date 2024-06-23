namespace Administracion_equipos_Roffo
{
    partial class Ver_inventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_volver_dashboard = new System.Windows.Forms.Button();
            this.button_agregar_parte = new System.Windows.Forms.Button();
            this.button_modificar_parte = new System.Windows.Forms.Button();
            this.button_eliminar_parte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(694, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_volver_dashboard
            // 
            this.button_volver_dashboard.Location = new System.Drawing.Point(620, 348);
            this.button_volver_dashboard.Name = "button_volver_dashboard";
            this.button_volver_dashboard.Size = new System.Drawing.Size(86, 36);
            this.button_volver_dashboard.TabIndex = 2;
            this.button_volver_dashboard.Text = "Volver al Dashboard";
            this.button_volver_dashboard.UseVisualStyleBackColor = true;
            this.button_volver_dashboard.Click += new System.EventHandler(this.button_volver_dashboard_Click);
            // 
            // button_agregar_parte
            // 
            this.button_agregar_parte.Location = new System.Drawing.Point(12, 348);
            this.button_agregar_parte.Name = "button_agregar_parte";
            this.button_agregar_parte.Size = new System.Drawing.Size(86, 36);
            this.button_agregar_parte.TabIndex = 3;
            this.button_agregar_parte.Text = "Agregar parte";
            this.button_agregar_parte.UseVisualStyleBackColor = true;
            this.button_agregar_parte.Click += new System.EventHandler(this.button_agregar_parte_Click);
            // 
            // button_modificar_parte
            // 
            this.button_modificar_parte.Location = new System.Drawing.Point(104, 348);
            this.button_modificar_parte.Name = "button_modificar_parte";
            this.button_modificar_parte.Size = new System.Drawing.Size(86, 36);
            this.button_modificar_parte.TabIndex = 4;
            this.button_modificar_parte.Text = "Modificar parte";
            this.button_modificar_parte.UseVisualStyleBackColor = true;
            this.button_modificar_parte.Click += new System.EventHandler(this.button_modificar_parte_Click);
            // 
            // button_eliminar_parte
            // 
            this.button_eliminar_parte.Location = new System.Drawing.Point(196, 348);
            this.button_eliminar_parte.Name = "button_eliminar_parte";
            this.button_eliminar_parte.Size = new System.Drawing.Size(86, 36);
            this.button_eliminar_parte.TabIndex = 5;
            this.button_eliminar_parte.Text = "Eliminar parte";
            this.button_eliminar_parte.UseVisualStyleBackColor = true;
            this.button_eliminar_parte.Click += new System.EventHandler(this.button_eliminar_parte_Click);
            // 
            // Ver_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 394);
            this.Controls.Add(this.button_eliminar_parte);
            this.Controls.Add(this.button_modificar_parte);
            this.Controls.Add(this.button_agregar_parte);
            this.Controls.Add(this.button_volver_dashboard);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ver_inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_volver_dashboard;
        private System.Windows.Forms.Button button_agregar_parte;
        private System.Windows.Forms.Button button_modificar_parte;
        private System.Windows.Forms.Button button_eliminar_parte;
    }
}