namespace Administracion_equipos_Roffo
{
    partial class Ver_reportes_equipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_equipo = new System.Windows.Forms.Label();
            this.label_lista_reporte = new System.Windows.Forms.Label();
            this.button_volver = new System.Windows.Forms.Button();
            this.label_marca = new System.Windows.Forms.Label();
            this.label_modelo = new System.Windows.Forms.Label();
            this.label_nro_serie = new System.Windows.Forms.Label();
            this.button_agregar_reporte = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(752, 272);
            this.dataGridView1.TabIndex = 1;
            // 
            // label_equipo
            // 
            this.label_equipo.AutoSize = true;
            this.label_equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipo.Location = new System.Drawing.Point(27, 9);
            this.label_equipo.Name = "label_equipo";
            this.label_equipo.Size = new System.Drawing.Size(53, 16);
            this.label_equipo.TabIndex = 2;
            this.label_equipo.Text = "Equipo:";
            // 
            // label_lista_reporte
            // 
            this.label_lista_reporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_lista_reporte.AutoSize = true;
            this.label_lista_reporte.Location = new System.Drawing.Point(330, 91);
            this.label_lista_reporte.Name = "label_lista_reporte";
            this.label_lista_reporte.Size = new System.Drawing.Size(117, 13);
            this.label_lista_reporte.TabIndex = 3;
            this.label_lista_reporte.Text = "LISTA DE REPORTES";
            // 
            // button_volver
            // 
            this.button_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver.Location = new System.Drawing.Point(663, 385);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(101, 53);
            this.button_volver.TabIndex = 4;
            this.button_volver.Text = "Volver a Equipos";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // label_marca
            // 
            this.label_marca.AutoSize = true;
            this.label_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marca.Location = new System.Drawing.Point(27, 28);
            this.label_marca.Name = "label_marca";
            this.label_marca.Size = new System.Drawing.Size(48, 16);
            this.label_marca.TabIndex = 5;
            this.label_marca.Text = "Marca:";
            // 
            // label_modelo
            // 
            this.label_modelo.AutoSize = true;
            this.label_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modelo.Location = new System.Drawing.Point(27, 47);
            this.label_modelo.Name = "label_modelo";
            this.label_modelo.Size = new System.Drawing.Size(56, 16);
            this.label_modelo.TabIndex = 6;
            this.label_modelo.Text = "Modelo:";
            // 
            // label_nro_serie
            // 
            this.label_nro_serie.AutoSize = true;
            this.label_nro_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nro_serie.Location = new System.Drawing.Point(27, 66);
            this.label_nro_serie.Name = "label_nro_serie";
            this.label_nro_serie.Size = new System.Drawing.Size(89, 16);
            this.label_nro_serie.TabIndex = 7;
            this.label_nro_serie.Text = "Nro. de Serie:";
            // 
            // button_agregar_reporte
            // 
            this.button_agregar_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_agregar_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar_reporte.Location = new System.Drawing.Point(12, 385);
            this.button_agregar_reporte.Name = "button_agregar_reporte";
            this.button_agregar_reporte.Size = new System.Drawing.Size(101, 53);
            this.button_agregar_reporte.TabIndex = 8;
            this.button_agregar_reporte.Text = "Agregar reporte";
            this.button_agregar_reporte.UseVisualStyleBackColor = true;
            this.button_agregar_reporte.Click += new System.EventHandler(this.button_agregar_reporte_Click);
            // 
            // Ver_reportes_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.button_agregar_reporte);
            this.Controls.Add(this.label_nro_serie);
            this.Controls.Add(this.label_modelo);
            this.Controls.Add(this.label_marca);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.label_lista_reporte);
            this.Controls.Add(this.label_equipo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ver_reportes_equipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes equipo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_equipo;
        private System.Windows.Forms.Label label_lista_reporte;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label label_marca;
        private System.Windows.Forms.Label label_modelo;
        private System.Windows.Forms.Label label_nro_serie;
        private System.Windows.Forms.Button button_agregar_reporte;
    }
}