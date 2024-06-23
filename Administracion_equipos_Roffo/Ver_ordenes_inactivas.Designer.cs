namespace Administracion_equipos_Roffo
{
    partial class Ver_ordenes_inactivas
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
            this.button_reabrir_orden = new System.Windows.Forms.Button();
            this.button_volver_Dashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(773, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // button_reabrir_orden
            // 
            this.button_reabrir_orden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_reabrir_orden.Location = new System.Drawing.Point(22, 355);
            this.button_reabrir_orden.Name = "button_reabrir_orden";
            this.button_reabrir_orden.Size = new System.Drawing.Size(102, 46);
            this.button_reabrir_orden.TabIndex = 3;
            this.button_reabrir_orden.Text = "Reabrir orden";
            this.button_reabrir_orden.UseVisualStyleBackColor = true;
            this.button_reabrir_orden.Click += new System.EventHandler(this.button_reabrir_orden_Click);
            // 
            // button_volver_Dashboard
            // 
            this.button_volver_Dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_volver_Dashboard.Location = new System.Drawing.Point(693, 356);
            this.button_volver_Dashboard.Name = "button_volver_Dashboard";
            this.button_volver_Dashboard.Size = new System.Drawing.Size(102, 46);
            this.button_volver_Dashboard.TabIndex = 4;
            this.button_volver_Dashboard.Text = "Volver al Dashboard";
            this.button_volver_Dashboard.UseVisualStyleBackColor = true;
            this.button_volver_Dashboard.Click += new System.EventHandler(this.button_volver_Dashboard_Click);
            // 
            // Ver_ordenes_inactivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 414);
            this.Controls.Add(this.button_volver_Dashboard);
            this.Controls.Add(this.button_reabrir_orden);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ver_ordenes_inactivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes inactivas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_reabrir_orden;
        private System.Windows.Forms.Button button_volver_Dashboard;
    }
}