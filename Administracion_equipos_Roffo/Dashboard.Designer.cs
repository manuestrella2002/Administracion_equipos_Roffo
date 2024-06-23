namespace Administracion_equipos_Roffo
{
    partial class Dashboard
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
            this.button_ver_equipos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ver_ordenes_inactivas = new System.Windows.Forms.Button();
            this.button_cerrar_orden = new System.Windows.Forms.Button();
            this.button_nueva_orden = new System.Windows.Forms.Button();
            this.button_modificar_orden = new System.Windows.Forms.Button();
            this.button_asociar_equipo = new System.Windows.Forms.Button();
            this.button_ver_grupos = new System.Windows.Forms.Button();
            this.button_inventario = new System.Windows.Forms.Button();
            this.button_proveedores = new System.Windows.Forms.Button();
            this.button_reporte_grupo = new System.Windows.Forms.Button();
            this.button_reparacion_externa = new System.Windows.Forms.Button();
            this.button_reporte_equipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ver_equipos
            // 
            this.button_ver_equipos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_ver_equipos.Location = new System.Drawing.Point(23, 115);
            this.button_ver_equipos.Name = "button_ver_equipos";
            this.button_ver_equipos.Size = new System.Drawing.Size(124, 71);
            this.button_ver_equipos.TabIndex = 0;
            this.button_ver_equipos.Text = "Ver equipos";
            this.button_ver_equipos.UseVisualStyleBackColor = true;
            this.button_ver_equipos.Click += new System.EventHandler(this.button_ver_equipos_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(165, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(690, 302);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ORDENES DE TRABAJO ACTIVAS";
            // 
            // button_ver_ordenes_inactivas
            // 
            this.button_ver_ordenes_inactivas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_ver_ordenes_inactivas.Location = new System.Drawing.Point(23, 38);
            this.button_ver_ordenes_inactivas.Name = "button_ver_ordenes_inactivas";
            this.button_ver_ordenes_inactivas.Size = new System.Drawing.Size(124, 71);
            this.button_ver_ordenes_inactivas.TabIndex = 3;
            this.button_ver_ordenes_inactivas.Text = "Ver ordenes cerradas";
            this.button_ver_ordenes_inactivas.UseVisualStyleBackColor = true;
            this.button_ver_ordenes_inactivas.Click += new System.EventHandler(this.button_ver_ordenes_inactivas_Click);
            // 
            // button_cerrar_orden
            // 
            this.button_cerrar_orden.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_cerrar_orden.Location = new System.Drawing.Point(731, 351);
            this.button_cerrar_orden.Name = "button_cerrar_orden";
            this.button_cerrar_orden.Size = new System.Drawing.Size(124, 71);
            this.button_cerrar_orden.TabIndex = 4;
            this.button_cerrar_orden.Text = "Cerrar orden";
            this.button_cerrar_orden.UseVisualStyleBackColor = true;
            this.button_cerrar_orden.Click += new System.EventHandler(this.button_cerrar_orden_Click);
            // 
            // button_nueva_orden
            // 
            this.button_nueva_orden.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_nueva_orden.Location = new System.Drawing.Point(165, 351);
            this.button_nueva_orden.Name = "button_nueva_orden";
            this.button_nueva_orden.Size = new System.Drawing.Size(124, 71);
            this.button_nueva_orden.TabIndex = 5;
            this.button_nueva_orden.Text = "Nueva Orden";
            this.button_nueva_orden.UseVisualStyleBackColor = true;
            this.button_nueva_orden.Click += new System.EventHandler(this.button_nueva_orden_Click);
            // 
            // button_modificar_orden
            // 
            this.button_modificar_orden.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_modificar_orden.Location = new System.Drawing.Point(295, 351);
            this.button_modificar_orden.Name = "button_modificar_orden";
            this.button_modificar_orden.Size = new System.Drawing.Size(124, 71);
            this.button_modificar_orden.TabIndex = 6;
            this.button_modificar_orden.Text = "Modificar orden";
            this.button_modificar_orden.UseVisualStyleBackColor = true;
            this.button_modificar_orden.Click += new System.EventHandler(this.button_modificar_orden_Click);
            // 
            // button_asociar_equipo
            // 
            this.button_asociar_equipo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_asociar_equipo.Location = new System.Drawing.Point(538, 351);
            this.button_asociar_equipo.Name = "button_asociar_equipo";
            this.button_asociar_equipo.Size = new System.Drawing.Size(124, 71);
            this.button_asociar_equipo.TabIndex = 7;
            this.button_asociar_equipo.Text = "Asociar equipo";
            this.button_asociar_equipo.UseVisualStyleBackColor = true;
            this.button_asociar_equipo.Click += new System.EventHandler(this.button_asociar_equipo_Click);
            // 
            // button_ver_grupos
            // 
            this.button_ver_grupos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_ver_grupos.Location = new System.Drawing.Point(874, 192);
            this.button_ver_grupos.Name = "button_ver_grupos";
            this.button_ver_grupos.Size = new System.Drawing.Size(124, 71);
            this.button_ver_grupos.TabIndex = 8;
            this.button_ver_grupos.Text = "Ver grupos electrogenos";
            this.button_ver_grupos.UseVisualStyleBackColor = true;
            this.button_ver_grupos.Click += new System.EventHandler(this.button_ver_grupos_Click);
            // 
            // button_inventario
            // 
            this.button_inventario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_inventario.Location = new System.Drawing.Point(874, 38);
            this.button_inventario.Name = "button_inventario";
            this.button_inventario.Size = new System.Drawing.Size(124, 71);
            this.button_inventario.TabIndex = 9;
            this.button_inventario.Text = "Inventario";
            this.button_inventario.UseVisualStyleBackColor = true;
            this.button_inventario.Click += new System.EventHandler(this.button_inventario_Click);
            // 
            // button_proveedores
            // 
            this.button_proveedores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_proveedores.Location = new System.Drawing.Point(874, 115);
            this.button_proveedores.Name = "button_proveedores";
            this.button_proveedores.Size = new System.Drawing.Size(124, 71);
            this.button_proveedores.TabIndex = 10;
            this.button_proveedores.Text = "Proveedores";
            this.button_proveedores.UseVisualStyleBackColor = true;
            this.button_proveedores.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_reporte_grupo
            // 
            this.button_reporte_grupo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_reporte_grupo.Location = new System.Drawing.Point(874, 269);
            this.button_reporte_grupo.Name = "button_reporte_grupo";
            this.button_reporte_grupo.Size = new System.Drawing.Size(124, 71);
            this.button_reporte_grupo.TabIndex = 11;
            this.button_reporte_grupo.Text = "Reportes grupos electrogenos";
            this.button_reporte_grupo.UseVisualStyleBackColor = true;
            this.button_reporte_grupo.Click += new System.EventHandler(this.button_reporte_grupo_Click);
            // 
            // button_reparacion_externa
            // 
            this.button_reparacion_externa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_reparacion_externa.Location = new System.Drawing.Point(23, 269);
            this.button_reparacion_externa.Name = "button_reparacion_externa";
            this.button_reparacion_externa.Size = new System.Drawing.Size(124, 71);
            this.button_reparacion_externa.TabIndex = 12;
            this.button_reparacion_externa.Text = "Reparación externa";
            this.button_reparacion_externa.UseVisualStyleBackColor = true;
            this.button_reparacion_externa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_reporte_equipo
            // 
            this.button_reporte_equipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_reporte_equipo.Location = new System.Drawing.Point(23, 192);
            this.button_reporte_equipo.Name = "button_reporte_equipo";
            this.button_reporte_equipo.Size = new System.Drawing.Size(124, 71);
            this.button_reporte_equipo.TabIndex = 13;
            this.button_reporte_equipo.Text = "Reportes equipos";
            this.button_reporte_equipo.UseVisualStyleBackColor = true;
            this.button_reporte_equipo.Click += new System.EventHandler(this.button_reporte_equipo_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 428);
            this.Controls.Add(this.button_reporte_equipo);
            this.Controls.Add(this.button_reparacion_externa);
            this.Controls.Add(this.button_reporte_grupo);
            this.Controls.Add(this.button_proveedores);
            this.Controls.Add(this.button_inventario);
            this.Controls.Add(this.button_ver_grupos);
            this.Controls.Add(this.button_asociar_equipo);
            this.Controls.Add(this.button_modificar_orden);
            this.Controls.Add(this.button_nueva_orden);
            this.Controls.Add(this.button_cerrar_orden);
            this.Controls.Add(this.button_ver_ordenes_inactivas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_ver_equipos);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ver_equipos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ver_ordenes_inactivas;
        private System.Windows.Forms.Button button_cerrar_orden;
        private System.Windows.Forms.Button button_nueva_orden;
        private System.Windows.Forms.Button button_modificar_orden;
        private System.Windows.Forms.Button button_asociar_equipo;
        private System.Windows.Forms.Button button_ver_grupos;
        private System.Windows.Forms.Button button_inventario;
        private System.Windows.Forms.Button button_proveedores;
        private System.Windows.Forms.Button button_reporte_grupo;
        private System.Windows.Forms.Button button_reparacion_externa;
        private System.Windows.Forms.Button button_reporte_equipo;
    }
}