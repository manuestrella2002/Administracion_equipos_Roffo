namespace Administracion_equipos_Roffo
{
    partial class Cerrar_reparacion_externa
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
            this.label_reporte_proveedor = new System.Windows.Forms.Label();
            this.textBox_reporte_proveedor = new System.Windows.Forms.TextBox();
            this.button_marcar_regreso = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_reporte_proveedor
            // 
            this.label_reporte_proveedor.AutoSize = true;
            this.label_reporte_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reporte_proveedor.Location = new System.Drawing.Point(12, 51);
            this.label_reporte_proveedor.Name = "label_reporte_proveedor";
            this.label_reporte_proveedor.Size = new System.Drawing.Size(125, 16);
            this.label_reporte_proveedor.TabIndex = 0;
            this.label_reporte_proveedor.Text = "Reporte proveedor:";
            // 
            // textBox_reporte_proveedor
            // 
            this.textBox_reporte_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reporte_proveedor.Location = new System.Drawing.Point(149, 48);
            this.textBox_reporte_proveedor.Multiline = true;
            this.textBox_reporte_proveedor.Name = "textBox_reporte_proveedor";
            this.textBox_reporte_proveedor.Size = new System.Drawing.Size(350, 99);
            this.textBox_reporte_proveedor.TabIndex = 1;
            // 
            // button_marcar_regreso
            // 
            this.button_marcar_regreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_marcar_regreso.Location = new System.Drawing.Point(387, 194);
            this.button_marcar_regreso.Name = "button_marcar_regreso";
            this.button_marcar_regreso.Size = new System.Drawing.Size(112, 54);
            this.button_marcar_regreso.TabIndex = 2;
            this.button_marcar_regreso.Text = "Marcar regreso de proveedor";
            this.button_marcar_regreso.UseVisualStyleBackColor = true;
            this.button_marcar_regreso.Click += new System.EventHandler(this.button_marcar_regreso_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(255, 194);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(112, 54);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // Cerrar_reparacion_externa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 260);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_marcar_regreso);
            this.Controls.Add(this.textBox_reporte_proveedor);
            this.Controls.Add(this.label_reporte_proveedor);
            this.Name = "Cerrar_reparacion_externa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar reparacion externa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_reporte_proveedor;
        private System.Windows.Forms.TextBox textBox_reporte_proveedor;
        private System.Windows.Forms.Button button_marcar_regreso;
        private System.Windows.Forms.Button button_cancelar;
    }
}