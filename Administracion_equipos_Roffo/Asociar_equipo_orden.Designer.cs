namespace Administracion_equipos_Roffo
{
    partial class Asociar_equipo_orden
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
            this.button_asociar = new System.Windows.Forms.Button();
            this.button_crear_equipo = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(948, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_asociar
            // 
            this.button_asociar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_asociar.Location = new System.Drawing.Point(408, 357);
            this.button_asociar.Name = "button_asociar";
            this.button_asociar.Size = new System.Drawing.Size(90, 37);
            this.button_asociar.TabIndex = 2;
            this.button_asociar.Text = "Asociar";
            this.button_asociar.UseVisualStyleBackColor = true;
            this.button_asociar.Click += new System.EventHandler(this.button_asociar_Click);
            // 
            // button_crear_equipo
            // 
            this.button_crear_equipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_crear_equipo.Location = new System.Drawing.Point(12, 357);
            this.button_crear_equipo.Name = "button_crear_equipo";
            this.button_crear_equipo.Size = new System.Drawing.Size(90, 37);
            this.button_crear_equipo.TabIndex = 3;
            this.button_crear_equipo.Text = "Crear equipo";
            this.button_crear_equipo.UseVisualStyleBackColor = true;
            this.button_crear_equipo.Click += new System.EventHandler(this.button_crear_equipo_Click);
            // 
            // button_volver
            // 
            this.button_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_volver.Location = new System.Drawing.Point(870, 357);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(90, 37);
            this.button_volver.TabIndex = 4;
            this.button_volver.Text = "Volver al Dashboard";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // Asociar_equipo_orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 406);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_crear_equipo);
            this.Controls.Add(this.button_asociar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Asociar_equipo_orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociar equipo a orden";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_asociar;
        private System.Windows.Forms.Button button_crear_equipo;
        private System.Windows.Forms.Button button_volver;
    }
}