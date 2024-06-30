namespace Administracion_equipos_Roffo
{
    partial class Ver_equipos
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
            this.button_agregar_equipo = new System.Windows.Forms.Button();
            this.button_modificar_equipo = new System.Windows.Forms.Button();
            this.button_eliminar_equipo = new System.Windows.Forms.Button();
            this.button_volver_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(948, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_agregar_equipo
            // 
            this.button_agregar_equipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_agregar_equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar_equipo.Location = new System.Drawing.Point(12, 336);
            this.button_agregar_equipo.Name = "button_agregar_equipo";
            this.button_agregar_equipo.Size = new System.Drawing.Size(118, 52);
            this.button_agregar_equipo.TabIndex = 1;
            this.button_agregar_equipo.Text = "Agregar Equipo";
            this.button_agregar_equipo.UseVisualStyleBackColor = true;
            this.button_agregar_equipo.Click += new System.EventHandler(this.button_agregar_equipo_Click);
            // 
            // button_modificar_equipo
            // 
            this.button_modificar_equipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_modificar_equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar_equipo.Location = new System.Drawing.Point(153, 336);
            this.button_modificar_equipo.Name = "button_modificar_equipo";
            this.button_modificar_equipo.Size = new System.Drawing.Size(110, 52);
            this.button_modificar_equipo.TabIndex = 2;
            this.button_modificar_equipo.Text = "Modificar Equipo";
            this.button_modificar_equipo.UseVisualStyleBackColor = true;
            this.button_modificar_equipo.Click += new System.EventHandler(this.button_modificar_equipo_Click);
            // 
            // button_eliminar_equipo
            // 
            this.button_eliminar_equipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_eliminar_equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar_equipo.Location = new System.Drawing.Point(297, 336);
            this.button_eliminar_equipo.Name = "button_eliminar_equipo";
            this.button_eliminar_equipo.Size = new System.Drawing.Size(113, 52);
            this.button_eliminar_equipo.TabIndex = 3;
            this.button_eliminar_equipo.Text = "Eliminar Equipo";
            this.button_eliminar_equipo.UseVisualStyleBackColor = true;
            this.button_eliminar_equipo.Click += new System.EventHandler(this.button_eliminar_equipo_Click);
            // 
            // button_volver_dashboard
            // 
            this.button_volver_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_volver_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver_dashboard.Location = new System.Drawing.Point(853, 336);
            this.button_volver_dashboard.Name = "button_volver_dashboard";
            this.button_volver_dashboard.Size = new System.Drawing.Size(107, 52);
            this.button_volver_dashboard.TabIndex = 4;
            this.button_volver_dashboard.Text = "Volver al Dashboard";
            this.button_volver_dashboard.UseVisualStyleBackColor = true;
            this.button_volver_dashboard.Click += new System.EventHandler(this.button_volver_dashboard_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de equipos";
            // 
            // Ver_equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_volver_dashboard);
            this.Controls.Add(this.button_eliminar_equipo);
            this.Controls.Add(this.button_modificar_equipo);
            this.Controls.Add(this.button_agregar_equipo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ver_equipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_agregar_equipo;
        private System.Windows.Forms.Button button_modificar_equipo;
        private System.Windows.Forms.Button button_eliminar_equipo;
        private System.Windows.Forms.Button button_volver_dashboard;
        private System.Windows.Forms.Label label1;
    }
}