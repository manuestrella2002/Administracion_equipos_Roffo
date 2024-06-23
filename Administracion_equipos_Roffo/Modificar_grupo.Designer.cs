namespace Administracion_equipos_Roffo
{
    partial class Modificar_grupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre_grupo = new System.Windows.Forms.TextBox();
            this.label_combustible = new System.Windows.Forms.Label();
            this.label_estado = new System.Windows.Forms.Label();
            this.comboBox_combustible = new System.Windows.Forms.ComboBox();
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.button_guardar_cambios = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre grupo electrogeno:";
            // 
            // textBox_nombre_grupo
            // 
            this.textBox_nombre_grupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nombre_grupo.Location = new System.Drawing.Point(185, 52);
            this.textBox_nombre_grupo.Name = "textBox_nombre_grupo";
            this.textBox_nombre_grupo.ReadOnly = true;
            this.textBox_nombre_grupo.Size = new System.Drawing.Size(106, 20);
            this.textBox_nombre_grupo.TabIndex = 1;
            // 
            // label_combustible
            // 
            this.label_combustible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_combustible.AutoSize = true;
            this.label_combustible.Location = new System.Drawing.Point(43, 101);
            this.label_combustible.Name = "label_combustible";
            this.label_combustible.Size = new System.Drawing.Size(67, 13);
            this.label_combustible.TabIndex = 2;
            this.label_combustible.Text = "Combustible:";
            // 
            // label_estado
            // 
            this.label_estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(43, 147);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(43, 13);
            this.label_estado.TabIndex = 3;
            this.label_estado.Text = "Estado:";
            // 
            // comboBox_combustible
            // 
            this.comboBox_combustible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_combustible.FormattingEnabled = true;
            this.comboBox_combustible.Items.AddRange(new object[] {
            "Gasoil Premium",
            "Gasoil Comun"});
            this.comboBox_combustible.Location = new System.Drawing.Point(116, 98);
            this.comboBox_combustible.Name = "comboBox_combustible";
            this.comboBox_combustible.Size = new System.Drawing.Size(121, 21);
            this.comboBox_combustible.TabIndex = 4;
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Items.AddRange(new object[] {
            "Fuera de servicio",
            "Operativo"});
            this.comboBox_estado.Location = new System.Drawing.Point(92, 144);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(121, 21);
            this.comboBox_estado.TabIndex = 5;
            // 
            // button_guardar_cambios
            // 
            this.button_guardar_cambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_guardar_cambios.Location = new System.Drawing.Point(302, 193);
            this.button_guardar_cambios.Name = "button_guardar_cambios";
            this.button_guardar_cambios.Size = new System.Drawing.Size(104, 39);
            this.button_guardar_cambios.TabIndex = 6;
            this.button_guardar_cambios.Text = "Guardar cambios";
            this.button_guardar_cambios.UseVisualStyleBackColor = true;
            this.button_guardar_cambios.Click += new System.EventHandler(this.button_guardar_cambios_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancelar.Location = new System.Drawing.Point(185, 193);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(104, 39);
            this.button_cancelar.TabIndex = 7;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // Modificar_grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 244);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_guardar_cambios);
            this.Controls.Add(this.comboBox_estado);
            this.Controls.Add(this.comboBox_combustible);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.label_combustible);
            this.Controls.Add(this.textBox_nombre_grupo);
            this.Controls.Add(this.label1);
            this.Name = "Modificar_grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar grupo electrogeno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre_grupo;
        private System.Windows.Forms.Label label_combustible;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.ComboBox comboBox_combustible;
        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.Button button_guardar_cambios;
        private System.Windows.Forms.Button button_cancelar;
    }
}