using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_equipos_Roffo
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button_ver_equipos_Click(object sender, EventArgs e)
        {
            Ver_equipos ver_Equipos = new Ver_equipos();

            this.Hide();
            ver_Equipos.ShowDialog();
            this.Show();

        }
    }
}
