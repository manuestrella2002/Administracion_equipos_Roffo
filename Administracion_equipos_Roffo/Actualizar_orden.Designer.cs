namespace Administracion_equipos_Roffo
{
    partial class Actualizar_orden
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
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_orden_de_trabajo = new System.Windows.Forms.Label();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripcion.Location = new System.Drawing.Point(22, 71);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(82, 16);
            this.label_descripcion.TabIndex = 0;
            this.label_descripcion.Text = "Descripcion:";
            // 
            // label_orden_de_trabajo
            // 
            this.label_orden_de_trabajo.AutoSize = true;
            this.label_orden_de_trabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orden_de_trabajo.Location = new System.Drawing.Point(177, 9);
            this.label_orden_de_trabajo.Name = "label_orden_de_trabajo";
            this.label_orden_de_trabajo.Size = new System.Drawing.Size(210, 16);
            this.label_orden_de_trabajo.TabIndex = 1;
            this.label_orden_de_trabajo.Text = "Actualización de orden de trabajo:";
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descripcion.Location = new System.Drawing.Point(94, 71);
            this.textBox_descripcion.Multiline = true;
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(354, 82);
            this.textBox_descripcion.TabIndex = 2;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(109, 193);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(84, 43);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Location = new System.Drawing.Point(360, 193);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(88, 43);
            this.button_guardar.TabIndex = 4;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // Actualizar_orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 248);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.label_orden_de_trabajo);
            this.Controls.Add(this.label_descripcion);
            this.Name = "Actualizar_orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar orden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_orden_de_trabajo;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_guardar;
    }
}