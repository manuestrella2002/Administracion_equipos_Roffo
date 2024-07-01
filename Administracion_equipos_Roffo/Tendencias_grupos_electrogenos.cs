using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Administracion_equipos_Roffo
{
    public partial class Tendencias_grupos_electrogenos : Form
    {
        public Tendencias_grupos_electrogenos()
        {
            InitializeComponent();
            LoadCharts();
        }

        private void LoadCharts()
        {
            // Define la cadena de conexión a tu base de datos MySQL
            string connectionString = "server=localhost;database=db_roffo;uid=root;pwd=1204;";

            // Define tu consulta SQL
            string query_resonador = "SELECT Fecha, Nivel_Combustible FROM reporte_grupo_electrogeno WHERE grupo_electrogeno_Id_grupo = 2";


            // Crea un DataTable para contener los datos
            DataTable tabla_resonador = new DataTable();

            // Conéctate a la base de datos y ejecuta la consulta
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query_resonador, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(tabla_resonador);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                    return;
                }
            }
            // Configurar el gráfico
            chart_tend_comb_resonador.Series.Clear();
            chart_tend_comb_resonador.Titles.Clear();

            Series series = new Series("Nivel de Combustible")
            {
                XValueType = ChartValueType.DateTime,
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,  // Grosor de la línea
                MarkerStyle = MarkerStyle.Circle,  // Estilo del marcador
                MarkerSize = 8  // Tamaño del marcador
            };

            chart_tend_comb_resonador.Series.Add(series);
            chart_tend_comb_resonador.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy"; // Solo muestra la fecha

            foreach (DataRow row in tabla_resonador.Rows)
            {
                DateTime fecha = Convert.ToDateTime(row["Fecha"]).Date;
                int nivelCombustible = Convert.ToInt32(row["Nivel_Combustible"]);
                series.Points.AddXY(fecha, nivelCombustible);
            }

            // Configurar el título del gráfico
            chart_tend_comb_resonador.Titles.Add("Tendencia del Nivel de Combustible (Resonador)");

            // Configurar el eje X
            chart_tend_comb_resonador.ChartAreas[0].AxisX.Title = "Fecha";

            // Configurar el eje Y
            chart_tend_comb_resonador.ChartAreas[0].AxisY.Title = "Nivel de Combustible";
            // Establecer límites del eje Y si es necesario (por ejemplo, entre 0 y 100)
            chart_tend_comb_resonador.ChartAreas[0].AxisY.Minimum = 0;
            chart_tend_comb_resonador.ChartAreas[0].AxisY.Maximum = 100;




        }



    }
}
