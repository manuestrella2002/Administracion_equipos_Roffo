namespace Administracion_equipos_Roffo
{
    partial class Ver_reparacion_externa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_volver_al_dashboard = new System.Windows.Forms.Button();
            this.button_agregar_salida = new System.Windows.Forms.Button();
            this.button_marcar_regreso = new System.Windows.Forms.Button();
            this.label_rep_ext_abiertas = new System.Windows.Forms.Label();
            this.label_rep_ext_cerradas = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(56, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(637, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_volver_al_dashboard
            // 
            this.button_volver_al_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_volver_al_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver_al_dashboard.Location = new System.Drawing.Point(582, 456);
            this.button_volver_al_dashboard.Name = "button_volver_al_dashboard";
            this.button_volver_al_dashboard.Size = new System.Drawing.Size(93, 52);
            this.button_volver_al_dashboard.TabIndex = 1;
            this.button_volver_al_dashboard.Text = "Volver al Dashboard";
            this.button_volver_al_dashboard.UseVisualStyleBackColor = true;
            this.button_volver_al_dashboard.Click += new System.EventHandler(this.button_volver_al_dashboard_Click);
            // 
            // button_agregar_salida
            // 
            this.button_agregar_salida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_agregar_salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar_salida.Location = new System.Drawing.Point(327, 456);
            this.button_agregar_salida.Name = "button_agregar_salida";
            this.button_agregar_salida.Size = new System.Drawing.Size(93, 52);
            this.button_agregar_salida.TabIndex = 2;
            this.button_agregar_salida.Text = "Agregar salida";
            this.button_agregar_salida.UseVisualStyleBackColor = true;
            this.button_agregar_salida.Click += new System.EventHandler(this.button_agregar_salida_Click);
            // 
            // button_marcar_regreso
            // 
            this.button_marcar_regreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_marcar_regreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_marcar_regreso.Location = new System.Drawing.Point(426, 456);
            this.button_marcar_regreso.Name = "button_marcar_regreso";
            this.button_marcar_regreso.Size = new System.Drawing.Size(93, 52);
            this.button_marcar_regreso.TabIndex = 3;
            this.button_marcar_regreso.Text = "Marcar regreso";
            this.button_marcar_regreso.UseVisualStyleBackColor = true;
            this.button_marcar_regreso.Click += new System.EventHandler(this.button_marcar_regreso_Click);
            // 
            // label_rep_ext_abiertas
            // 
            this.label_rep_ext_abiertas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_rep_ext_abiertas.AutoSize = true;
            this.label_rep_ext_abiertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rep_ext_abiertas.Location = new System.Drawing.Point(275, 11);
            this.label_rep_ext_abiertas.Name = "label_rep_ext_abiertas";
            this.label_rep_ext_abiertas.Size = new System.Drawing.Size(199, 16);
            this.label_rep_ext_abiertas.TabIndex = 4;
            this.label_rep_ext_abiertas.Text = "Reparaciones externas abiertas";
            // 
            // label_rep_ext_cerradas
            // 
            this.label_rep_ext_cerradas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_rep_ext_cerradas.AutoSize = true;
            this.label_rep_ext_cerradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rep_ext_cerradas.Location = new System.Drawing.Point(272, 227);
            this.label_rep_ext_cerradas.Name = "label_rep_ext_cerradas";
            this.label_rep_ext_cerradas.Size = new System.Drawing.Size(204, 16);
            this.label_rep_ext_cerradas.TabIndex = 6;
            this.label_rep_ext_cerradas.Text = "Reparaciones externas cerradas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(56, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(637, 197);
            this.dataGridView2.TabIndex = 5;
            // 
            // Ver_reparacion_externa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 514);
            this.Controls.Add(this.label_rep_ext_cerradas);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label_rep_ext_abiertas);
            this.Controls.Add(this.button_marcar_regreso);
            this.Controls.Add(this.button_agregar_salida);
            this.Controls.Add(this.button_volver_al_dashboard);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ver_reparacion_externa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparaciones  externas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_volver_al_dashboard;
        private System.Windows.Forms.Button button_agregar_salida;
        private System.Windows.Forms.Button button_marcar_regreso;
        private System.Windows.Forms.Label label_rep_ext_abiertas;
        private System.Windows.Forms.Label label_rep_ext_cerradas;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}