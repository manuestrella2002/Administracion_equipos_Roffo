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
            this.SuspendLayout();
            // 
            // button_ver_equipos
            // 
            this.button_ver_equipos.Location = new System.Drawing.Point(66, 80);
            this.button_ver_equipos.Name = "button_ver_equipos";
            this.button_ver_equipos.Size = new System.Drawing.Size(124, 71);
            this.button_ver_equipos.TabIndex = 0;
            this.button_ver_equipos.Text = "Ver equipos";
            this.button_ver_equipos.UseVisualStyleBackColor = true;
            this.button_ver_equipos.Click += new System.EventHandler(this.button_ver_equipos_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 391);
            this.Controls.Add(this.button_ver_equipos);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ver_equipos;
    }
}