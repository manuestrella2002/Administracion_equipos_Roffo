﻿namespace Administracion_equipos_Roffo
{
    partial class Ver_proveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_volver_dashboard = new System.Windows.Forms.Button();
            this.button_eliminar_prov = new System.Windows.Forms.Button();
            this.button_modificar_prov = new System.Windows.Forms.Button();
            this.button_agregar_prov = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista de proveedores";
            // 
            // button_volver_dashboard
            // 
            this.button_volver_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_volver_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver_dashboard.Location = new System.Drawing.Point(807, 381);
            this.button_volver_dashboard.Name = "button_volver_dashboard";
            this.button_volver_dashboard.Size = new System.Drawing.Size(103, 46);
            this.button_volver_dashboard.TabIndex = 10;
            this.button_volver_dashboard.Text = "Volver al Dashboard";
            this.button_volver_dashboard.UseVisualStyleBackColor = true;
            this.button_volver_dashboard.Click += new System.EventHandler(this.button_volver_dashboard_Click);
            // 
            // button_eliminar_prov
            // 
            this.button_eliminar_prov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_eliminar_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar_prov.Location = new System.Drawing.Point(270, 381);
            this.button_eliminar_prov.Name = "button_eliminar_prov";
            this.button_eliminar_prov.Size = new System.Drawing.Size(104, 47);
            this.button_eliminar_prov.TabIndex = 9;
            this.button_eliminar_prov.Text = "Eliminar proveedor";
            this.button_eliminar_prov.UseVisualStyleBackColor = true;
            this.button_eliminar_prov.Click += new System.EventHandler(this.button_eliminar_prov_Click);
            // 
            // button_modificar_prov
            // 
            this.button_modificar_prov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_modificar_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar_prov.Location = new System.Drawing.Point(139, 381);
            this.button_modificar_prov.Name = "button_modificar_prov";
            this.button_modificar_prov.Size = new System.Drawing.Size(104, 47);
            this.button_modificar_prov.TabIndex = 8;
            this.button_modificar_prov.Text = "Modificar Proveedor";
            this.button_modificar_prov.UseVisualStyleBackColor = true;
            this.button_modificar_prov.Click += new System.EventHandler(this.button_modificar_prov_Click);
            // 
            // button_agregar_prov
            // 
            this.button_agregar_prov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_agregar_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar_prov.Location = new System.Drawing.Point(10, 381);
            this.button_agregar_prov.Name = "button_agregar_prov";
            this.button_agregar_prov.Size = new System.Drawing.Size(108, 47);
            this.button_agregar_prov.TabIndex = 7;
            this.button_agregar_prov.Text = "Agregar proveedor";
            this.button_agregar_prov.UseVisualStyleBackColor = true;
            this.button_agregar_prov.Click += new System.EventHandler(this.button_agregar_prov_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(900, 330);
            this.dataGridView1.TabIndex = 6;
            // 
            // Ver_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_volver_dashboard);
            this.Controls.Add(this.button_eliminar_prov);
            this.Controls.Add(this.button_modificar_prov);
            this.Controls.Add(this.button_agregar_prov);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ver_proveedores";
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_volver_dashboard;
        private System.Windows.Forms.Button button_eliminar_prov;
        private System.Windows.Forms.Button button_modificar_prov;
        private System.Windows.Forms.Button button_agregar_prov;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}